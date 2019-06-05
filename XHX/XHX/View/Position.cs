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
    public partial class Position : BaseForm
    {
        XtraGridDataHandler<PositionDto> dataHandler = null;
        LocalService local = new LocalService();
        public Position()
        {
            InitializeComponent();
            OnLoadView();
        }
        public void OnLoadView()
        {
            dataHandler = new XtraGridDataHandler<PositionDto>(grvPosition);
        }
        public void InitializeView()
        {
            grcPosition.DataSource = null;
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            this.CSParentForm.EnabelButton(ButtonType.AddRowButton, false);
            this.CSParentForm.EnabelButton(ButtonType.SaveButton, false);
        }

        public override List<ButtonType> CreateButton()
        {
            List<ButtonType> list = new List<ButtonType>();
            list.Add(ButtonType.InitButton);
            list.Add(ButtonType.SearchButton);
            list.Add(ButtonType.AddRowButton);
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
            SearchArea();
            this.CSParentForm.EnabelButton(ButtonType.AddRowButton, true);
            this.CSParentForm.EnabelButton(ButtonType.SaveButton, true);
        }
        public override void AddRowButtonClick()
        {
            PositionDto area = new PositionDto();
            area.PositionCode = "0";
            dataHandler.AddRow(area);
        }
        public override void SaveButtonClick()
        {
            if (base.UserInfoDto.RoleType != "S")
            {
                CommonHandler.ShowMessage(MessageType.Information, "没有权限");
                return;
            }
            grvPosition.CloseEditor();
            grvPosition.UpdateCurrentRow();
            if (CommonHandler.ShowMessage(MessageType.Confirm, "确定要保存吗？") == DialogResult.Yes)
            {
                List<PositionDto> areaList = dataHandler.DataList;
                foreach (PositionDto area in areaList)
                {
                    local.PositionSave(Convert.ToInt32(area.PositionCode), area.PositionName,area.Remark,this.UserInfoDto.UserID);
                }
            }
            SearchArea();
            CommonHandler.ShowMessage(MessageType.Information, "保存完毕");
        }

        private void SearchArea()
        {
            List<PositionDto> positionList = new List<PositionDto>();
            DataSet ds = local.PositionSearch(0,txtPositionName.Text.Trim());
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    PositionDto area = new PositionDto();
                    area.PositionCode = Convert.ToString(ds.Tables[0].Rows[i]["PositionCode"]);
                    area.PositionName = Convert.ToString(ds.Tables[0].Rows[i]["PositionName"]);
                    area.Remark = Convert.ToString(ds.Tables[0].Rows[i]["Remark"]);
                    area.InUserId = Convert.ToString(ds.Tables[0].Rows[i]["InUserId"]);
                    area.InDateTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["InDateTime"]);
                    positionList.Add(area);
                }
            }

            grcPosition.DataSource = positionList;
        }

        private void grvPosition_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == gcPositionCode
                ||e.Column==gcUserId
                ||e.Column==gcInDateTime)
            {
                e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
                e.Appearance.ForeColor = Color.Black;
            }
        }

    }


}
