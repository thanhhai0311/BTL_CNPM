namespace center_management_app.Components
{
    partial class UCAccountManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAccountManager));
            this.gridAccount = new DevExpress.XtraGrid.GridControl();
            this.menuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditInfotoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbGroups = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cExistsProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            this.menuAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGroups.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAccount
            // 
            this.gridAccount.ContextMenuStrip = this.menuAccount;
            this.gridAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAccount.Location = new System.Drawing.Point(0, 0);
            this.gridAccount.MainView = this.gridView1;
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.Size = new System.Drawing.Size(1381, 660);
            this.gridAccount.TabIndex = 0;
            this.gridAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridAccount.Click += new System.EventHandler(this.gridAccount_Click);
            // 
            // menuAccount
            // 
            this.menuAccount.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.EditInfotoolStripMenuItem1,
            this.deleteAccountToolStripMenuItem});
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(193, 94);
            this.menuAccount.Opening += new System.ComponentModel.CancelEventHandler(this.menuAccount_Opening);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.reloadToolStripMenuItem.Text = "Tải Lại Dữ Liệu";
            // 
            // EditInfotoolStripMenuItem1
            // 
            this.EditInfotoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("EditInfotoolStripMenuItem1.Image")));
            this.EditInfotoolStripMenuItem1.Name = "EditInfotoolStripMenuItem1";
            this.EditInfotoolStripMenuItem1.Size = new System.Drawing.Size(192, 30);
            this.EditInfotoolStripMenuItem1.Text = "Chỉnh Sửa Thông Tin";
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteAccountToolStripMenuItem.Image")));
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.deleteAccountToolStripMenuItem.Text = "Xóa";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cNumber,
            this.cAvatar,
            this.cName,
            this.cPhoneNumber,
            this.cDob,
            this.cGender,
            this.cStatus});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridAccount;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            this.gridView1.PreviewIndent = 0;
            // 
            // cNumber
            // 
            this.cNumber.Caption = "Chỉ số";
            this.cNumber.FieldName = "cNumber";
            this.cNumber.Name = "cNumber";
            this.cNumber.Visible = true;
            this.cNumber.VisibleIndex = 1;
            this.cNumber.Width = 42;
            // 
            // cAvatar
            // 
            this.cAvatar.Caption = "Ảnh";
            this.cAvatar.FieldName = "cAvatar";
            this.cAvatar.Name = "cAvatar";
            this.cAvatar.Visible = true;
            this.cAvatar.VisibleIndex = 2;
            this.cAvatar.Width = 37;
            // 
            // cName
            // 
            this.cName.Caption = "Tên học viên";
            this.cName.FieldName = "cName";
            this.cName.Name = "cName";
            this.cName.Visible = true;
            this.cName.VisibleIndex = 3;
            this.cName.Width = 164;
            // 
            // cPhoneNumber
            // 
            this.cPhoneNumber.Caption = "Số điện thoại";
            this.cPhoneNumber.FieldName = "cPhoneNumber";
            this.cPhoneNumber.Name = "cPhoneNumber";
            this.cPhoneNumber.Visible = true;
            this.cPhoneNumber.VisibleIndex = 4;
            this.cPhoneNumber.Width = 121;
            // 
            // cDob
            // 
            this.cDob.Caption = "Ngày sinh";
            this.cDob.FieldName = "cDob";
            this.cDob.Name = "cDob";
            this.cDob.Visible = true;
            this.cDob.VisibleIndex = 6;
            this.cDob.Width = 106;
            // 
            // cGender
            // 
            this.cGender.Caption = "Giới tính";
            this.cGender.FieldName = "cGender";
            this.cGender.Name = "cGender";
            this.cGender.Visible = true;
            this.cGender.VisibleIndex = 5;
            this.cGender.Width = 66;
            // 
            // cStatus
            // 
            this.cStatus.Caption = "Trạng thái";
            this.cStatus.FieldName = "cStatus";
            this.cStatus.Name = "cStatus";
            this.cStatus.Visible = true;
            this.cStatus.VisibleIndex = 7;
            this.cStatus.Width = 168;
            // 
            // cbGroups
            // 
            this.cbGroups.Location = new System.Drawing.Point(553, 13);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGroups.Size = new System.Drawing.Size(310, 28);
            this.cbGroups.TabIndex = 1;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(885, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 28);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Tải Lại Dữ Liệu";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cFullName
            // 
            this.cFullName.Caption = "Tên tài khoản";
            this.cFullName.FieldName = "cFullName";
            this.cFullName.Name = "cFullName";
            this.cFullName.Width = 110;
            // 
            // cExistsProfile
            // 
            this.cExistsProfile.Caption = " ";
            this.cExistsProfile.FieldName = "cExistsProfile";
            this.cExistsProfile.Name = "cExistsProfile";
            this.cExistsProfile.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.cExistsProfile.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.False;
            this.cExistsProfile.Width = 42;
            // 
            // cNo
            // 
            this.cNo.Caption = "#";
            this.cNo.FieldName = "cNo";
            this.cNo.Name = "cNo";
            this.cNo.Width = 42;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // UCAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbGroups);
            this.Controls.Add(this.gridAccount);
            this.Name = "UCAccountManager";
            this.Size = new System.Drawing.Size(1381, 660);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            this.menuAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGroups.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAccount;
        private DevExpress.XtraGrid.Columns.GridColumn cPhoneNumber;
        private DevExpress.XtraEditors.ComboBoxEdit cbGroups;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ContextMenuStrip menuAccount;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn cDob;
        private DevExpress.XtraGrid.Columns.GridColumn cGender;
        private DevExpress.XtraGrid.Columns.GridColumn cFullName;
        private DevExpress.XtraGrid.Columns.GridColumn cExistsProfile;
        private DevExpress.XtraGrid.Columns.GridColumn cNo;
        private DevExpress.XtraGrid.Columns.GridColumn cNumber;
        private DevExpress.XtraGrid.Columns.GridColumn cName;
        private DevExpress.XtraGrid.Columns.GridColumn cStatus;
        private DevExpress.XtraGrid.Columns.GridColumn cAvatar;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ToolStripMenuItem EditInfotoolStripMenuItem1;
    }
}
