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
    public partial class Projects : BaseForm
    {
        XtraGridDataHandler<ProjectDto> dataHandler = null;
        LocalService local = new LocalService();
        public Projects()
        {
            InitializeComponent();
            dataHandler = new XtraGridDataHandler<ProjectDto>(grvProject);
            OnLoadView();
        }
        public void OnLoadView()
        {
            SearchProject();
        }
        private void Shop_Load(object sender, EventArgs e)
        {
            //this.CSParentForm.EnabelButton(ButtonType.AddRowButton, false);
            //this.CSParentForm.EnabelButton(ButtonType.SaveButton, false);
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
            OnLoadView();
        }
        public override void SearchButtonClick()
        {
            SearchProject();
            this.CSParentForm.EnabelButton(ButtonType.AddRowButton, true);
            this.CSParentForm.EnabelButton(ButtonType.SaveButton, true);
        }
        public override void AddRowButtonClick()
        {
            ProjectDto project = new ProjectDto();
            dataHandler.AddRow(project);
        }
        public override void SaveButtonClick()
        {
            grvProject.CloseEditor();
            grvProject.UpdateCurrentRow();
            grvProject.RefreshData();
            if (base.UserInfoDto.RoleType != "S")
            {
                CommonHandler.ShowMessage(MessageType.Information, "没有权限");
            }
            if (CommonHandler.ShowMessage(MessageType.Confirm, "确定要保存吗？") == DialogResult.Yes)
            {
                List<ProjectDto> projectList = dataHandler.DataList;
                foreach (ProjectDto project in projectList)
                {
                    local.ProjectSave(project.StatusType, project.ProjectCode, project.Year, project.Quarter);
                }
            }
            SearchProject();
            CommonHandler.ShowMessage(MessageType.Information, "保存完毕");
        }

        private void SearchProject()
        {            
            List<ProjectDto> projectList = new List<ProjectDto>();
            DataSet ds = local.ProjectSearch();
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProjectDto project = new ProjectDto();
                    project.ProjectCode = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCode"]);
                    project.ProjectName = Convert.ToString(ds.Tables[0].Rows[i]["ProjectName"]);
                    project.Year = Convert.ToString(ds.Tables[0].Rows[i]["Year"]);
                    project.Quarter = Convert.ToString(ds.Tables[0].Rows[i]["Quarter"]);
                    project.OrderNO = Convert.ToInt32(ds.Tables[0].Rows[i]["OrderNO"]);
                    project.DataChk = Convert.ToBoolean(ds.Tables[0].Rows[i]["DataChk"]);
                    projectList.Add(project);
                }
                grcProject.DataSource = projectList;
            }
            else
            {
                CommonHandler.ShowMessage(MessageType.Information, "没有数据");
                return;
            }
        }

        private void grvArea_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            ProjectDto area = grvProject.GetRow(e.RowHandle) as ProjectDto;
            if (area.StatusType != 'I')
            {
                e.Appearance.BackColor = CommonHandler.GetReadOnlyColor();
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void grvArea_ShowingEditor(object sender, CancelEventArgs e)
        {
            ProjectDto area = grvProject.GetRow(grvProject.FocusedRowHandle) as ProjectDto;


                if (area.StatusType != 'I')
                {
                    e.Cancel = true;
                }            
        }


        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ProjectDto project = grvProject.GetRow(grvProject.FocusedRowHandle) as ProjectDto;
            if (project.ProjectCode == null || string.IsNullOrEmpty(project.ProjectCode))
            {
                CommonHandler.ShowMessage(MessageType.Information, "请先保存");
                return;
            }
            if (project.DataChk)
            {
                CommonHandler.ShowMessage(MessageType.Information, "已经有数据不能复制");
                return;
            }
            if (CommonHandler.ShowMessage(MessageType.Confirm, "确定要复制吗？") == DialogResult.Yes)
            {
                local.CopyData((grvProject.GetRow(grvProject.FocusedRowHandle) as ProjectDto).ProjectCode);
                CommonHandler.ShowMessage(MessageType.Information, "复制完成");
            }
            SearchProject();
        }

        private void grcProject_Click(object sender, EventArgs e)
        {
            if (grvProject.FocusedColumn == gridColumn1)
            {
                repositoryItemButtonEdit1_ButtonClick(null, null);
            }
        }
    }


}
