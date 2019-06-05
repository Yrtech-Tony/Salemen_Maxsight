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

namespace XHX.View
{
    public partial class Shop_Popup : DevExpress.XtraEditors.XtraForm
    {
        ShopDto shopdto = null;
        List<ShopDto> shopList = new List<ShopDto>();

        public List<ShopDto> ShopList
        {
            get { return shopList; }
            set { shopList = value; }
        }
        LocalService webService = new LocalService();

        public ShopDto Shopdto
        {
            get { return shopdto; }
            set { shopdto = value; }
        }
        GridCheckMarksSelection selection;
        internal GridCheckMarksSelection Selection
        {
            get
            {
                return selection;
            }
        }
        public Shop_Popup()
        {

        }
        public Shop_Popup(string projectCode,string shopCode, string shopName, bool check)
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(CommonHandler.Skin_Name);

            BindComBox.BindProject(cboProjects);
            CommonHandler.SetComboBoxSelectedValue(cboProjects, projectCode);
            BindArea();
            txtShopCode.Text = shopCode;
            txtShop.Text = shopName;
            Search();
            if (check)
            {
                selection = new GridCheckMarksSelection(gridView1);
                selection.CheckMarkColumn.VisibleIndex = 0;
            }
            else
            {

            }
        }
        public void BindArea()
        {
            DataSet ds = webService.AreaSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(), "", "");
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
        private void Search()
        {
            DataSet ds = webService.ShopSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(),
                txtShopCode.Text.Trim(),txtShop.Text.Trim());
            List<ShopDto> shoplist = new List<ShopDto>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ShopDto shop = new ShopDto();
                    shop.AreaCode = Convert.ToString(ds.Tables[0].Rows[i]["AreaCode"]);
                    shop.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    shop.ShopName = Convert.ToString(ds.Tables[0].Rows[i]["ShopName"]);
                    shoplist.Add(shop);
                }
            }
            grcShop.DataSource = shoplist;
        }
        public void InitializeView()
        {
            txtShop.Text = "";
            txtShopCode.Text = "";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            shopdto = gridView1.GetRow(gridView1.FocusedRowHandle) as ShopDto;
            this.Close();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName != "CheckMarkSelection")
                e.Appearance.BackColor = Color.Gray;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "CheckMarkSelection") != null && gridView1.GetRowCellValue(i, "CheckMarkSelection").ToString() == "True")
                {
                    shopList.Add(gridView1.GetRow(i) as ShopDto);
                }
            }
            this.Close();
        }
    }
}
