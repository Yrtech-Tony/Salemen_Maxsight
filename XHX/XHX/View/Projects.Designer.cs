namespace XHX.View
{
    partial class Projects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdShop = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grcProject = new DevExpress.XtraGrid.GridControl();
            this.grvProject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAreaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcQu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcDataChk = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdShop
            // 
            this.grdShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdShop.Location = new System.Drawing.Point(5, 5);
            this.grdShop.Margin = new System.Windows.Forms.Padding(0);
            this.grdShop.Name = "grdShop";
            this.grdShop.Size = new System.Drawing.Size(988, 42);
            this.grdShop.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(5, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(988, 5);
            this.labelControl2.TabIndex = 11;
            // 
            // grcProject
            // 
            this.grcProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcProject.Location = new System.Drawing.Point(5, 52);
            this.grcProject.MainView = this.grvProject;
            this.grcProject.Name = "grcProject";
            this.grcProject.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.grcProject.Size = new System.Drawing.Size(988, 556);
            this.grcProject.TabIndex = 12;
            this.grcProject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProject});
            this.grcProject.Click += new System.EventHandler(this.grcProject_Click);
            // 
            // grvProject
            // 
            this.grvProject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcProject,
            this.gcAreaCode,
            this.gcYear,
            this.gcQu,
            this.gridColumn2,
            this.gridColumn1,
            this.gcDataChk});
            this.grvProject.GridControl = this.grcProject;
            this.grvProject.Name = "grvProject";
            this.grvProject.OptionsView.ShowGroupPanel = false;
            this.grvProject.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvArea_CustomDrawCell);
            this.grvProject.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvArea_ShowingEditor);
            // 
            // gcProject
            // 
            this.gcProject.AppearanceCell.Options.UseTextOptions = true;
            this.gcProject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcProject.AppearanceHeader.Options.UseTextOptions = true;
            this.gcProject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcProject.Caption = "期号";
            this.gcProject.FieldName = "ProjectCode";
            this.gcProject.Name = "gcProject";
            this.gcProject.OptionsColumn.ReadOnly = true;
            this.gcProject.Visible = true;
            this.gcProject.VisibleIndex = 0;
            this.gcProject.Width = 186;
            // 
            // gcAreaCode
            // 
            this.gcAreaCode.AppearanceCell.Options.UseTextOptions = true;
            this.gcAreaCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcAreaCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gcAreaCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcAreaCode.Caption = "期号名称";
            this.gcAreaCode.FieldName = "ProjectName";
            this.gcAreaCode.Name = "gcAreaCode";
            this.gcAreaCode.OptionsColumn.ReadOnly = true;
            this.gcAreaCode.Visible = true;
            this.gcAreaCode.VisibleIndex = 1;
            this.gcAreaCode.Width = 212;
            // 
            // gcYear
            // 
            this.gcYear.AppearanceCell.Options.UseTextOptions = true;
            this.gcYear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcYear.AppearanceHeader.Options.UseTextOptions = true;
            this.gcYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcYear.Caption = "年份";
            this.gcYear.FieldName = "Year";
            this.gcYear.Name = "gcYear";
            this.gcYear.Visible = true;
            this.gcYear.VisibleIndex = 2;
            this.gcYear.Width = 276;
            // 
            // gcQu
            // 
            this.gcQu.AppearanceCell.Options.UseTextOptions = true;
            this.gcQu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcQu.AppearanceHeader.Options.UseTextOptions = true;
            this.gcQu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcQu.Caption = "季度";
            this.gcQu.FieldName = "Quarter";
            this.gcQu.Name = "gcQu";
            this.gcQu.Visible = true;
            this.gcQu.VisibleIndex = 3;
            this.gcQu.Width = 141;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "序号";
            this.gridColumn2.FieldName = "OrderNO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 152;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "复制上期数据";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 167;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // gcDataChk
            // 
            this.gcDataChk.Caption = "gridColumn3";
            this.gcDataChk.FieldName = "DataChk";
            this.gcDataChk.Name = "gcDataChk";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.grcProject);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grdShop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Projects";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(998, 613);
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl grdShop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grcProject;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProject;
        private DevExpress.XtraGrid.Columns.GridColumn gcProject;
        private DevExpress.XtraGrid.Columns.GridColumn gcYear;
        private DevExpress.XtraGrid.Columns.GridColumn gcAreaCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcQu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDataChk;


    }
}