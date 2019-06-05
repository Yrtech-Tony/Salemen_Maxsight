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
    public partial class Area : BaseForm
    {
        XtraGridDataHandler<AreaDto> dataHandler = null;
        LocalService local = new LocalService();
        public Area()
        {
            InitializeComponent();
            dataHandler = new XtraGridDataHandler<AreaDto>(grvArea);
            OnLoadView();
        }
        public void OnLoadView()
        {
            //为查询条件中Cbo绑定
            BindComBox.BindProject(cboProjects);

        }
        public void InitializeView()
        {
            cboProjects.SelectedIndex = 0;
            grcArea.DataSource = null;
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
            if (base.UserInfoDto.RoleType != "C")
            {
                this.CSParentForm.EnabelButton(ButtonType.AddRowButton, true);
                this.CSParentForm.EnabelButton(ButtonType.SaveButton, true);
            }
            else
            {
                this.CSParentForm.EnabelButton(ButtonType.AddRowButton, false);
                this.CSParentForm.EnabelButton(ButtonType.SaveButton, false);
            }
        }
        public override void AddRowButtonClick()
        {
            AreaDto area = new AreaDto();
            area.ProjectCode = CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString();
            dataHandler.AddRow(area);
        }
        public override void SaveButtonClick()
        {
            if (base.UserInfoDto.RoleType != "S")
            {
                CommonHandler.ShowMessage(MessageType.Information, "没有权限");
                return;
            }
            grvArea.CloseEditor();
            grvArea.UpdateCurrentRow();

            foreach (AreaDto area in grcArea.DataSource as List<AreaDto>)
            {
                //验证 区域代码
                if (string.IsNullOrEmpty(area.AreaCode))
                {
                    CommonHandler.ShowMessage(MessageType.Information, "区域代码不能为空");
                    grvArea.FocusedColumn = gcAreaCode;
                    grvArea.FocusedRowHandle = (grcArea.DataSource as List<AreaDto>).IndexOf(area);
                    return;
                }
                foreach (AreaDto s in dataHandler.DataList)
                {
                    if (s != area && s.AreaCode == area.AreaCode)
                    {
                        CommonHandler.ShowMessage(MessageType.Information, "区域代码不能重复");
                        grvArea.FocusedColumn = gcAreaCode;
                        grvArea.FocusedRowHandle = (grcArea.DataSource as List<AreaDto>).IndexOf(area);
                        return;
                    }
                }
                //验证 区域名称
                if (string.IsNullOrEmpty(area.AreaName))
                {
                    CommonHandler.ShowMessage(MessageType.Information, "区域名称不能为空");
                    grvArea.FocusedColumn = gcAreaName;
                    grvArea.FocusedRowHandle = (grcArea.DataSource as List<AreaDto>).IndexOf(area);
                    return;
                }
                foreach (AreaDto s in dataHandler.DataList)
                {
                    if (s != area && s.AreaName == area.AreaName)
                    {
                        CommonHandler.ShowMessage(MessageType.Information, "区域名称不能重复");
                        grvArea.FocusedColumn = gcAreaName;
                        grvArea.FocusedRowHandle = (grcArea.DataSource as List<AreaDto>).IndexOf(area);
                        return;
                    }
                }
            }
            if (CommonHandler.ShowMessage(MessageType.Confirm, "确定要保存吗？") == DialogResult.Yes)
            {
                List<AreaDto> areaList = dataHandler.DataList;
                foreach (AreaDto area in areaList)
                {
                    local.AreaSave(area.ProjectCode,area.AreaName,area.AreaCode,this.UserInfoDto.UserID);
                }
            }
            SearchArea();
            CommonHandler.ShowMessage(MessageType.Information, "保存完毕");
        }

        private void SearchArea()
        {
            List<AreaDto> areaList = new List<AreaDto>();
            DataSet ds = local.AreaSearch(CommonHandler.GetComboBoxSelectedValue(cboProjects).ToString(),
                txtAreaName.Text.Trim(), "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    AreaDto area = new AreaDto();
                    area.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    area.AreaCode = Convert.ToString(ds.Tables[0].Rows[i]["AreaCode"]);
                    area.AreaName = Convert.ToString(ds.Tables[0].Rows[i]["AreaName"]);
                    area.InUserId = Convert.ToString(ds.Tables[0].Rows[i]["InUserId"]);
                    area.InDateTime = Convert.ToDateTime(ds.Tables[0].Rows[i]["InDateTime"]);
                    areaList.Add(area);
                }
            }
            grcArea.DataSource = areaList;
        }

        private void grvArea_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            AreaDto area = grvArea.GetRow(e.RowHandle) as AreaDto;
            if (area.StatusType != 'I')
            {
                e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
                e.Appearance.ForeColor = Color.Black;
            }
            if (e.Column == gcProject
                ||e.Column==gridColumn1
                ||e.Column==gridColumn2)
            {
                e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void grvArea_ShowingEditor(object sender, CancelEventArgs e)
        {
            AreaDto area = grvArea.GetRow(grvArea.FocusedRowHandle) as AreaDto;
            if (area.StatusType != 'I')
            {
                e.Cancel = true;
            }
        }
    }


}
