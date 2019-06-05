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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
//using XHX.WebService;

namespace XHX.View
{
    public partial class ShopUserLossRate : BaseForm
    {
        XtraGridDataHandler<ShopLossRateDto> dataHandler = null;
        XtraGridDataHandler<ShopLossRateDtlDto> dataHandlerdtl = null;
        LocalService local = new LocalService();
        public ShopUserLossRate()
        {
            InitializeComponent();
            dataHandler = new XtraGridDataHandler<ShopLossRateDto>(grvShop);
            dataHandlerdtl = new XtraGridDataHandler<ShopLossRateDtlDto>(grvPosition);
            OnLoadView();
        }
        public void OnLoadView()
        {
            //为查询条件中Cbo绑定
            BindComBox.BindProject(cboProjects);
            BindArea();

        }
        public void InitializeView()
        {
            cboProjects.SelectedIndex = 0;
            grcShop.DataSource = null;
            grcPosition.DataSource = null;
            btnShopCode.Text = "";
            txtShopName.Text = "";
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
            list.Add(ButtonType.ExcelDownButton);
            return list;
        }
        public override void InitButtonClick()
        {
            base.InitButtonClick();

            InitializeView();
        }
        public override void SearchButtonClick()
        {
            SearchLossRateMst();
        }
        public override void ExcelDownButtonClick()
        {
            if (grcShop.DataSource != null)
            {
                CommonHandler.ExcelExport(grvShop);
            }
            if (grcPosition.DataSource != null)
            {
                CommonHandler.ExcelExport(grvPosition);
            }
        }
        private void SearchLossRateMst()
        {
            List<ShopLossRateDto> areaList = new List<ShopLossRateDto>();
            DataSet ds = local.LossRateMstSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(),
                btnShopCode.Text.Trim());
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ShopLossRateDto area = new ShopLossRateDto();
                    //area.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    //area.AreaCode = Convert.ToString(ds.Tables[0].Rows[i]["AreaCode"]);
                    area.AreaName = Convert.ToString(ds.Tables[0].Rows[i]["AreaName"]);
                    area.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    area.ShopName = Convert.ToString(ds.Tables[0].Rows[i]["ShopName"]);
                    area.LossRate = Convert.ToString(ds.Tables[0].Rows[i]["Ratio"]);
                    area.CountThis = Convert.ToString(ds.Tables[0].Rows[i]["NowCnt"]);
                    area.CountLast = Convert.ToString(ds.Tables[0].Rows[i]["LastCnt"]);
                    areaList.Add(area);
                }
            }
            grcShop.DataSource = areaList;
            grcPosition.DataSource = null;
        }
        private void SearchLossRateDtl()
        {
            List<ShopLossRateDtlDto> areaList = new List<ShopLossRateDtlDto>();
            DataSet ds = local.LossRateDtlSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(),
                (grvShop.GetRow(grvShop.FocusedRowHandle) as ShopLossRateDto).ShopCode);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ShopLossRateDtlDto area = new ShopLossRateDtlDto();
                    //area.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    area.PositionName = Convert.ToString(ds.Tables[0].Rows[i]["PositionName"]);
                    //area.ShopCode = Convert.ToString(ds.Tables[0].Rows[i]["ShopCode"]);
                    area.PositionCountLast = Convert.ToString(ds.Tables[0].Rows[i]["LastCnt"]);
                    area.PositionCountThis = Convert.ToString(ds.Tables[0].Rows[i]["NowCnt"]);
                    area.PositionLossRate = Convert.ToString(ds.Tables[0].Rows[i]["Ratio"]);
                    area.AuthCountThis = Convert.ToString(ds.Tables[0].Rows[i]["NowCnt_A"]);
                    area.AuthCountLast = Convert.ToString(ds.Tables[0].Rows[i]["LastCnt_A"]);
                    area.AuthLossRate = Convert.ToString(ds.Tables[0].Rows[i]["Ratio_A"]);
                    areaList.Add(area);
                }
            }
            grcPosition.DataSource = areaList;
        }


        private void btnShopCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Shop_Popup pop = new Shop_Popup(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(), "", "", false);
            pop.ShowDialog();
            ShopDto dto = pop.Shopdto;
            if (dto != null)
            {
                btnShopCode.Text = dto.ShopCode;
                txtShopName.Text = dto.ShopName;
            }
        }

        private void grvShop_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
            e.Appearance.ForeColor = Color.Black;
        }

        private void grvPosition_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
            e.Appearance.ForeColor = Color.Black;
        }

        private void grcShop_Click(object sender, EventArgs e)
        {
            //ShopLossRateDto shop = grvShop.GetRow(grvShop.FocusedRowHandle) as ShopLossRateDto;
            SearchLossRateDtl();
        }
    }


}
