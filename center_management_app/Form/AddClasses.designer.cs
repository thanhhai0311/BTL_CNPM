namespace center_management_app.Forms
{
    partial class AddClassesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassesForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.SpinEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcGroups = new DevExpress.XtraGrid.GridControl();
            this.gvGroups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTeacherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteGroup = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comboBoxEdit1);
            this.panelControl1.Controls.Add(this.comboBoxEdit2);
            this.panelControl1.Controls.Add(this.txtFullName);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.comboBoxEdit3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(1028, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(503, 587);
            this.panelControl1.TabIndex = 0;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(172, 183);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Tiếng Anh 1",
            "Tiếng Anh 2",
            "Tiếng Anh 3",
            "Tiếng Trung 1",
            "Tiếng Trung 2"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(273, 34);
            this.comboBoxEdit1.TabIndex = 16;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(172, 116);
            this.comboBoxEdit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "Tiếng Anh 1",
            "Tiếng Anh 2",
            "Tiếng Anh 3",
            "Tiếng Trung 1",
            "Tiếng Trung 2"});
            this.comboBoxEdit2.Size = new System.Drawing.Size(273, 34);
            this.comboBoxEdit2.TabIndex = 15;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(172, 52);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(273, 34);
            this.txtFullName.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(34, 257);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Sỉ Số";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 192);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Chọn Giáo Viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 124);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Môn Học";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Lớp Học";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thêm Lớp Học";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Controls.Add(this.simpleButton2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 519);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(499, 66);
            this.panelControl3.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(80, 16);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 38);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Hủy";
            // 
            // simpleButton2
            // 
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(304, 16);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(138, 38);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Thêm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.comboBoxEdit3.Location = new System.Drawing.Point(172, 249);
            this.comboBoxEdit3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.comboBoxEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.comboBoxEdit3.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.comboBoxEdit3.Size = new System.Drawing.Size(114, 34);
            this.comboBoxEdit3.TabIndex = 17;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcGroups);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1028, 587);
            this.panelControl2.TabIndex = 1;
            // 
            // gcGroups
            // 
            this.gcGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGroups.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcGroups.Location = new System.Drawing.Point(2, 2);
            this.gcGroups.MainView = this.gvGroups;
            this.gcGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcGroups.Name = "gcGroups";
            this.gcGroups.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteGroup});
            this.gcGroups.Size = new System.Drawing.Size(1024, 583);
            this.gcGroups.TabIndex = 2;
            this.gcGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGroups});
            // 
            // gvGroups
            // 
            this.gvGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cIndex,
            this.cClassName,
            this.cTeacherName,
            this.cTotal,
            this.cSubject,
            this.cAction});
            this.gvGroups.DetailHeight = 431;
            this.gvGroups.GridControl = this.gcGroups;
            this.gvGroups.Name = "gvGroups";
            this.gvGroups.OptionsFind.AllowFindPanel = false;
            this.gvGroups.OptionsView.ShowGroupPanel = false;
            // 
            // cIndex
            // 
            this.cIndex.Caption = "Chỉ Số";
            this.cIndex.FieldName = "cIndex";
            this.cIndex.MinWidth = 23;
            this.cIndex.Name = "cIndex";
            this.cIndex.OptionsColumn.AllowEdit = false;
            this.cIndex.Visible = true;
            this.cIndex.VisibleIndex = 0;
            this.cIndex.Width = 117;
            // 
            // cClassName
            // 
            this.cClassName.Caption = "Tên Lớp Học";
            this.cClassName.FieldName = "cClassName";
            this.cClassName.MinWidth = 23;
            this.cClassName.Name = "cClassName";
            this.cClassName.Visible = true;
            this.cClassName.VisibleIndex = 1;
            this.cClassName.Width = 308;
            // 
            // cTeacherName
            // 
            this.cTeacherName.Caption = "Giáo Viên";
            this.cTeacherName.FieldName = "cTeacherName";
            this.cTeacherName.MinWidth = 23;
            this.cTeacherName.Name = "cTeacherName";
            this.cTeacherName.Visible = true;
            this.cTeacherName.VisibleIndex = 2;
            this.cTeacherName.Width = 507;
            // 
            // cTotal
            // 
            this.cTotal.Caption = "Sỉ Số";
            this.cTotal.FieldName = "cTotal";
            this.cTotal.MinWidth = 23;
            this.cTotal.Name = "cTotal";
            this.cTotal.OptionsColumn.AllowEdit = false;
            this.cTotal.Visible = true;
            this.cTotal.VisibleIndex = 4;
            this.cTotal.Width = 110;
            // 
            // cSubject
            // 
            this.cSubject.Caption = "Môn học";
            this.cSubject.FieldName = "cSubject";
            this.cSubject.MinWidth = 23;
            this.cSubject.Name = "cSubject";
            this.cSubject.OptionsColumn.AllowEdit = false;
            this.cSubject.Visible = true;
            this.cSubject.VisibleIndex = 3;
            this.cSubject.Width = 322;
            // 
            // cAction
            // 
            this.cAction.AppearanceCell.Options.UseTextOptions = true;
            this.cAction.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cAction.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cAction.AppearanceHeader.Options.UseTextOptions = true;
            this.cAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cAction.Caption = "Hành Động";
            this.cAction.ColumnEdit = this.btnDeleteGroup;
            this.cAction.FieldName = "cAction";
            this.cAction.MinWidth = 23;
            this.cAction.Name = "cAction";
            this.cAction.OptionsFilter.AllowAutoFilter = false;
            this.cAction.OptionsFilter.AllowFilter = false;
            this.cAction.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.cAction.Visible = true;
            this.cAction.VisibleIndex = 5;
            this.cAction.Width = 157;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.AllowFocused = false;
            this.btnDeleteGroup.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDeleteGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // AddClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 587);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AddClassesForm.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddClassesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.AddClassesForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddGroups_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGroups;
        private DevExpress.XtraGrid.Columns.GridColumn cIndex;
        private DevExpress.XtraGrid.Columns.GridColumn cClassName;
        private DevExpress.XtraGrid.Columns.GridColumn cTeacherName;
        private DevExpress.XtraGrid.Columns.GridColumn cTotal;
        private DevExpress.XtraGrid.Columns.GridColumn cSubject;
        private DevExpress.XtraGrid.Columns.GridColumn cAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteGroup;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.SpinEdit comboBoxEdit3;
    }
}