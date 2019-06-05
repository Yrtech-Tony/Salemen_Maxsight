namespace XHX.View
{
    partial class Position
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
            this.txtPositionName = new DevExpress.XtraEditors.TextEdit();
            this.lblAreaName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grcPosition = new DevExpress.XtraGrid.GridControl();
            this.grvPosition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPositionCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAreaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).BeginInit();
            this.grdShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPositionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // grdShop
            // 
            this.grdShop.Controls.Add(this.txtPositionName);
            this.grdShop.Controls.Add(this.lblAreaName);
            this.grdShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdShop.Location = new System.Drawing.Point(5, 5);
            this.grdShop.Margin = new System.Windows.Forms.Padding(0);
            this.grdShop.Name = "grdShop";
            this.grdShop.Size = new System.Drawing.Size(988, 42);
            this.grdShop.TabIndex = 10;
            // 
            // txtPositionName
            // 
            this.txtPositionName.Location = new System.Drawing.Point(77, 19);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(266, 21);
            this.txtPositionName.TabIndex = 5;
            // 
            // lblAreaName
            // 
            this.lblAreaName.Location = new System.Drawing.Point(23, 22);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(48, 14);
            this.lblAreaName.TabIndex = 4;
            this.lblAreaName.Text = "职位名称";
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
            // grcPosition
            // 
            this.grcPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPosition.Location = new System.Drawing.Point(5, 52);
            this.grcPosition.MainView = this.grvPosition;
            this.grcPosition.Name = "grcPosition";
            this.grcPosition.Size = new System.Drawing.Size(988, 556);
            this.grcPosition.TabIndex = 12;
            this.grcPosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPosition});
            // 
            // grvPosition
            // 
            this.grvPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcPositionCode,
            this.gcAreaCode,
            this.gridColumn1,
            this.gcUserId,
            this.gcInDateTime});
            this.grvPosition.GridControl = this.grcPosition;
            this.grvPosition.Name = "grvPosition";
            this.grvPosition.OptionsView.ShowGroupPanel = false;
            this.grvPosition.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvPosition_CustomDrawCell);
            // 
            // gcPositionCode
            // 
            this.gcPositionCode.AppearanceCell.Options.UseTextOptions = true;
            this.gcPositionCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcPositionCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gcPositionCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcPositionCode.Caption = "职位代码";
            this.gcPositionCode.FieldName = "PositionCode";
            this.gcPositionCode.Name = "gcPositionCode";
            this.gcPositionCode.OptionsColumn.ReadOnly = true;
            this.gcPositionCode.Visible = true;
            this.gcPositionCode.VisibleIndex = 0;
            this.gcPositionCode.Width = 148;
            // 
            // gcAreaCode
            // 
            this.gcAreaCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gcAreaCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcAreaCode.Caption = "职位名称";
            this.gcAreaCode.FieldName = "PositionName";
            this.gcAreaCode.Name = "gcAreaCode";
            this.gcAreaCode.Visible = true;
            this.gcAreaCode.VisibleIndex = 1;
            this.gcAreaCode.Width = 223;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "备注";
            this.gridColumn1.FieldName = "Remark";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 195;
            // 
            // gcUserId
            // 
            this.gcUserId.AppearanceCell.Options.UseTextOptions = true;
            this.gcUserId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcUserId.AppearanceHeader.Options.UseTextOptions = true;
            this.gcUserId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcUserId.Caption = "登记人";
            this.gcUserId.FieldName = "InUserId";
            this.gcUserId.Name = "gcUserId";
            this.gcUserId.OptionsColumn.ReadOnly = true;
            this.gcUserId.Visible = true;
            this.gcUserId.VisibleIndex = 3;
            this.gcUserId.Width = 195;
            // 
            // gcInDateTime
            // 
            this.gcInDateTime.AppearanceCell.Options.UseTextOptions = true;
            this.gcInDateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcInDateTime.AppearanceHeader.Options.UseTextOptions = true;
            this.gcInDateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcInDateTime.Caption = "登记日期";
            this.gcInDateTime.FieldName = "InDateTime";
            this.gcInDateTime.Name = "gcInDateTime";
            this.gcInDateTime.OptionsColumn.ReadOnly = true;
            this.gcInDateTime.Visible = true;
            this.gcInDateTime.VisibleIndex = 4;
            this.gcInDateTime.Width = 206;
            // 
            // Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.grcPosition);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grdShop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Position";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(998, 613);
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShop)).EndInit();
            this.grdShop.ResumeLayout(false);
            this.grdShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPositionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl grdShop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grcPosition;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPosition;
        private DevExpress.XtraGrid.Columns.GridColumn gcPositionCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcUserId;
        private DevExpress.XtraGrid.Columns.GridColumn gcAreaCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcInDateTime;
        private DevExpress.XtraEditors.TextEdit txtPositionName;
        private DevExpress.XtraEditors.LabelControl lblAreaName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;


    }
}