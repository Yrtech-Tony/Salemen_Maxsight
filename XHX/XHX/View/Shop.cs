using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XHX.Common;
using XHX.DTO;
using DevExpress.XtraEditors.Repository;
//using XHX.WebService;

namespace XHX.View
{
    public partial class Shop : BaseForm
    {
        XtraGridDataHandler<ShopDto> dataHandler = null;
        LocalService local = new LocalService();

        public Shop()
        {
            InitializeComponent();
            OnLoadView();
        }

        public void OnLoadView()
        {
            BindComBox.BindProject(cboProjects);
            BindArea();
            dataHandler = new XtraGridDataHandler<ShopDto>(grvShop);
        }
        public void InitializeView()
        {
            txtShopName.Text = "";
            BindComBox.BindProject(cboProjects);
            BindArea();
            grcShop.DataSource = null;
        }
        public void BindArea()
        {
            DataSet ds = local.AreaSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(), "", "");
            List<AreaDto> list = new List<AreaDto>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    AreaDto subjectType = new AreaDto();
                    subjectType.AreaCode = Convert.ToString(ds.Tables[0].Rows[i]["AreaCode"]);
                    subjectType.AreaName = Convert.ToString(ds.Tables[0].Rows[i]["AreaName"]);
                    list.Add(subjectType);
                }
            }
            CommonHandler.BindComboBoxItems<AreaDto>(cboArea, list, "AreaName", "AreaCode");
        }
        public override List<ButtonType> CreateButton()
        {
            List<ButtonType> list = new List<ButtonType>();
            list.Add(ButtonType.InitButton);
            list.Add(ButtonType.SearchButton);
            list.Add(ButtonType.AddRowButton);
            list.Add(ButtonType.DeleteButton);
            list.Add(ButtonType.SaveButton);

            return list;
        }
        public override void InitButtonClick()
        {
            base.InitButtonClick();
            InitializeView();
        }
        public override void SearchButtonClick()
        {
            SearchShop();
            this.CSParentForm.EnabelButton(ButtonType.AddRowButton, true);
            this.CSParentForm.EnabelButton(ButtonType.SaveButton, true);
            this.CSParentForm.EnabelButton(ButtonType.DeleteButton, true);
        }
        public override void AddRowButtonClick()
        {
            ShopDto shop = new ShopDto();
            shop.ProjectCode = CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString();
            shop.UseChk = true;
            dataHandler.AddRow(shop);
        }
        public override void DeleteButtonClick()
        {
            if (CommonHandler.ShowMessage(MessageType.Confirm, "确定要删除吗？") == DialogResult.Yes)
            {
                ShopDto shop = grvShop.GetRow(grvShop.FocusedRowHandle) as ShopDto;
                local.ShopDelete(shop.ProjectCode, shop.ShopCode);
                CommonHandler.ShowMessage(MessageType.Information, "删除完毕");
            }
            SearchShop();
        }
        public override void SaveButtonClick()
        {
            grvShop.CloseEditor();
            grvShop.UpdateCurrentRow();

            if (base.UserInfoDto.RoleType != "S")
            {
                CommonHandler.ShowMessage(MessageType.Information, "没有权限");
            }
            foreach (ShopDto shop in grcShop.DataSource as List<ShopDto>)
            {
                if (string.IsNullOrEmpty(shop.ShopCode))
                {
                    CommonHandler.ShowMessage(MessageType.Information, "经销商代码不能为空");
                    grvShop.FocusedColumn = gcShopCode;
                    grvShop.FocusedRowHandle = (grcShop.DataSource as List<ShopDto>).IndexOf(shop);
                    return;
                }

                foreach (ShopDto s in dataHandler.DataList)
                {
                    if (s != shop)
                    {
                        if (s.ShopCode == shop.ShopCode)
                        {
                            CommonHandler.ShowMessage(MessageType.Information, "经销商代码不能重复");
                            grvShop.FocusedColumn = gcShopCode;
                            grvShop.FocusedRowHandle = (grcShop.DataSource as List<ShopDto>).IndexOf(s);
                            return;
                        }
                    }
                }
            }
            if (CommonHandler.ShowMessage(MessageType.Confirm, "确定要保存吗？") == DialogResult.Yes)
            {
                List<ShopDto> shopList = dataHandler.DataList;
                foreach (ShopDto shop in shopList)
                {

                    local.ShopSave(shop.ProjectCode, shop.ShopCode, shop.ShopName
                        , shop.AreaCode, this.UserInfoDto.UserID);
                }
            }
            SearchShop();
            CommonHandler.ShowMessage(MessageType.Information, "保存完毕");
        }
        private void SearchShop()
        {
            List<ShopDto> shopList = new List<ShopDto>();
            DataSet ds = local.ShopSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString()
                                , "", txtShopName.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ShopDto shop = new ShopDto();
                    shop.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    shop.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    shop.ShopName = Convert.ToString(ds.Tables[0].Rows[i]["ShopName"]);
                    shop.AreaCode = Convert.ToString(ds.Tables[0].Rows[i]["AreaCode"]);
                    shop.InUserId = Convert.ToString(ds.Tables[0].Rows[i]["InUserId"]);
                    shop.InDateTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["InDateTime"]);
                    shopList.Add(shop);
                }
            }

            grcShop.DataSource = shopList;
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            this.CSParentForm.EnabelButton(ButtonType.AddRowButton, false);
            this.CSParentForm.EnabelButton(ButtonType.SaveButton, false);
            this.CSParentForm.EnabelButton(ButtonType.DeleteButton, false);
        }
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            ShopDto shop = grvShop.GetRow(grvShop.FocusedRowHandle) as ShopDto;
            if (grvShop.FocusedColumn == gcShopCode)
            {
                if (shop.StatusType != 'I')
                {
                    e.Cancel = true;

                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (grcShop.DataSource == null || grvShop.RowCount == 0) return;
            ShopDto shop = grvShop.GetRow(e.RowHandle) as ShopDto;
            if (e.Column == gcShopCode && shop.StatusType != 'I'
                )
            {
                e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
                e.Appearance.ForeColor = Color.Black;
            }
            if (e.Column == gcInDateTime || e.Column == gcInUserId)
            {
                e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
                e.Appearance.ForeColor = Color.Black;
            }
        }

    }


}
