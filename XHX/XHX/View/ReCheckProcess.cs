using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XHX.DTO;

namespace XHX.View
{
    public partial class ReCheckProcess : BaseForm
    {
        #region Field
        localhost.Service service = new localhost.Service();
        #endregion
        #region Construtor
        public ReCheckProcess()
        {
            InitializeComponent();
            InitView();
            InitData();
        }
        #endregion
        #region Private Method
        private void InitData()
        {
            XHX.Common.BindComBox.BindProject(cboProjects);
            grcRecheckProcess.DataSource = null;
            grcRecheckProcess.DataSource = new List<AnswerStatusTypeCodeDto>();
            CommonHandler.SetRowNumberIndicator(grvRecheckProcess);
        }
        private void InitView()
        {
            btnShopCode.Text = "";
            txtShopName.Text = "";
        }
        private void SearchAnswerLog()
        {
            string projectCode = CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString();
            string shopCode = btnShopCode.Text;
            List<AnswerStatusTypeCodeDto> list = new List<AnswerStatusTypeCodeDto>();
            DataSet ds = service.SearchReCheckProcess(projectCode, shopCode);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    AnswerStatusTypeCodeDto answer = new AnswerStatusTypeCodeDto();
                    answer.ShopCode = Convert.ToString(ds.Tables[0].Rows[j]["ShopCode"]);
                    answer.ShopName = Convert.ToString(ds.Tables[0].Rows[j]["ShopName"]);
                    answer.StatusCode = Convert.ToString(ds.Tables[0].Rows[j]["StatusCode"]);
                    //answer.StatusName = Convert.ToString(ds.Tables[0].Rows[j]["CNDesc"]);
                    if (answer.StatusCode == "S0")
                    {
                        answer.RecheckRegister = "■";
                    }
                    else if (answer.StatusCode == "S1")
                    {
                        answer.ModifyFinish = "■";
                    }
                    else if (answer.StatusCode == "S2")
                    {
                        answer.ReCheckFinish = "■";
                    }
                    else
                    {
                        answer.RecheckProcess = "■" + answer.StatusCode;
                    }
                    
                    
                    list.Add(answer);
                }


            }
            else
            {
                list = new List<AnswerStatusTypeCodeDto>();
            }
            grcRecheckProcess.DataSource = list;

        }

        #endregion
        #region Event
        private void btnShopCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Shop_Popup pop = new Shop_Popup("", "", false);
            pop.ShowDialog();
            ShopDto dto = pop.Shopdto;
            if (dto != null)
            {
                btnShopCode.Text = dto.ShopCode;
                txtShopName.Text = dto.ShopName;
            }
        }
        #endregion

 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAnswerLog();
        }

        private void grvRecheckProcess_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (grvRecheckProcess.FocusedColumn != e.Column&&grvRecheckProcess.FocusedRowHandle==e.RowHandle)
            {
                e.Appearance.ForeColor = Color.White;
            }
            else
            {
                e.Appearance.ForeColor = Color.Black;
            }
        }
        public override void SearchButtonClick()
        {
            SearchAnswerLog();
        }
        public override void InitButtonClick()
        {
            InitView();
            InitData();
        }
        public override void ExcelDownButtonClick()
        {
            if (grcRecheckProcess.DataSource != null)
                CommonHandler.ExcelExport(grvRecheckProcess);
        }
        public override List<ButtonType> CreateButton()
        {
            List<ButtonType> list = new List<ButtonType>();
            list.Add(ButtonType.InitButton);
            list.Add(ButtonType.SearchButton);
            list.Add(ButtonType.ExcelDownButton);
            return list;
        }
    }
}
