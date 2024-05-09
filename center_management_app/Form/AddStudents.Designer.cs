using center_management_app.Services.models;
using System;
using System.Linq;
using System.Windows.Forms;
using center_management_app.Services;
using System.Collections.Generic;

namespace center_management_app.Forms
{
    partial class AddStudentsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentsForm));
            this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lbcID = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lbcEmail = new DevExpress.XtraEditors.LabelControl();
            this.cbClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbcClass = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lbcAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.lbcPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbcDob = new DevExpress.XtraEditors.LabelControl();
            this.lbcGender = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.lbcFullName = new DevExpress.XtraEditors.LabelControl();
            this.cbDob = new DevExpress.XtraEditors.DateEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialog
            // 
            this.xtraOpenFileDialog.FileName = "xtraOpenFileDialog1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 427);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(573, 69);
            this.panelControl1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(317, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(104, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Hủy";
            this.btnClose.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtID);
            this.panelControl2.Controls.Add(this.lbcID);
            this.panelControl2.Controls.Add(this.txtEmail);
            this.panelControl2.Controls.Add(this.lbcEmail);
            this.panelControl2.Controls.Add(this.cbClass);
            this.panelControl2.Controls.Add(this.lbcClass);
            this.panelControl2.Controls.Add(this.txtAddress);
            this.panelControl2.Controls.Add(this.lbcAddress);
            this.panelControl2.Controls.Add(this.txtPhoneNumber);
            this.panelControl2.Controls.Add(this.lbcPhoneNumber);
            this.panelControl2.Controls.Add(this.cbGender);
            this.panelControl2.Controls.Add(this.lbcDob);
            this.panelControl2.Controls.Add(this.lbcGender);
            this.panelControl2.Controls.Add(this.txtFullName);
            this.panelControl2.Controls.Add(this.lbcFullName);
            this.panelControl2.Controls.Add(this.cbDob);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(573, 427);
            this.panelControl2.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(206, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(105, 34);
            this.txtID.TabIndex = 18;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            // 
            // lbcID
            // 
            this.lbcID.Location = new System.Drawing.Point(74, 30);
            this.lbcID.Margin = new System.Windows.Forms.Padding(4);
            this.lbcID.Name = "lbcID";
            this.lbcID.Size = new System.Drawing.Size(12, 16);
            this.lbcID.TabIndex = 17;
            this.lbcID.Text = "ID";
            this.lbcID.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(206, 228);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 34);
            this.txtEmail.TabIndex = 16;
            // 
            // lbcEmail
            // 
            this.lbcEmail.Location = new System.Drawing.Point(74, 237);
            this.lbcEmail.Margin = new System.Windows.Forms.Padding(4);
            this.lbcEmail.Name = "lbcEmail";
            this.lbcEmail.Size = new System.Drawing.Size(31, 16);
            this.lbcEmail.TabIndex = 15;
            this.lbcEmail.Text = "Email\r\n";
            this.lbcEmail.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // cbClass
            // 
            this.cbClass.Location = new System.Drawing.Point(206, 317);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbClass.Size = new System.Drawing.Size(273, 34);
            this.cbClass.TabIndex = 14;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit2_SelectedIndexChanged);
            // 
            // lbcClass
            // 
            this.lbcClass.Location = new System.Drawing.Point(74, 326);
            this.lbcClass.Margin = new System.Windows.Forms.Padding(4);
            this.lbcClass.Name = "lbcClass";
            this.lbcClass.Size = new System.Drawing.Size(45, 16);
            this.lbcClass.TabIndex = 13;
            this.lbcClass.Text = "Lớp Học";
            this.lbcClass.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(206, 270);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 34);
            this.txtAddress.TabIndex = 10;
            // 
            // lbcAddress
            // 
            this.lbcAddress.Location = new System.Drawing.Point(74, 279);
            this.lbcAddress.Margin = new System.Windows.Forms.Padding(4);
            this.lbcAddress.Name = "lbcAddress";
            this.lbcAddress.Size = new System.Drawing.Size(41, 16);
            this.lbcAddress.TabIndex = 9;
            this.lbcAddress.Text = "Địa Chỉ";
            this.lbcAddress.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(206, 187);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPhoneNumber.Size = new System.Drawing.Size(161, 34);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // lbcPhoneNumber
            // 
            this.lbcPhoneNumber.Location = new System.Drawing.Point(74, 196);
            this.lbcPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lbcPhoneNumber.Name = "lbcPhoneNumber";
            this.lbcPhoneNumber.Size = new System.Drawing.Size(81, 16);
            this.lbcPhoneNumber.TabIndex = 7;
            this.lbcPhoneNumber.Text = "Số Điện Thoại";
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(206, 103);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbGender.Size = new System.Drawing.Size(161, 34);
            this.cbGender.TabIndex = 5;
            // 
            // lbcDob
            // 
            this.lbcDob.Location = new System.Drawing.Point(74, 154);
            this.lbcDob.Margin = new System.Windows.Forms.Padding(4);
            this.lbcDob.Name = "lbcDob";
            this.lbcDob.Size = new System.Drawing.Size(57, 16);
            this.lbcDob.TabIndex = 4;
            this.lbcDob.Text = "Ngày Sinh";
            // 
            // lbcGender
            // 
            this.lbcGender.Location = new System.Drawing.Point(74, 112);
            this.lbcGender.Margin = new System.Windows.Forms.Padding(4);
            this.lbcGender.Name = "lbcGender";
            this.lbcGender.Size = new System.Drawing.Size(50, 16);
            this.lbcGender.TabIndex = 2;
            this.lbcGender.Text = "Giới Tính";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(206, 62);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(273, 34);
            this.txtFullName.TabIndex = 1;
            // 
            // lbcFullName
            // 
            this.lbcFullName.Location = new System.Drawing.Point(74, 71);
            this.lbcFullName.Margin = new System.Windows.Forms.Padding(4);
            this.lbcFullName.Name = "lbcFullName";
            this.lbcFullName.Size = new System.Drawing.Size(76, 16);
            this.lbcFullName.TabIndex = 0;
            this.lbcFullName.Text = "Tên Học Viên";
            this.lbcFullName.Click += new System.EventHandler(this.lbcName_Click);
            // 
            // cbDob
            // 
            //this.cbDob.EditValue = new System.DateTime(2024, 4, 24, 18, 56, 11, 0);
            this.cbDob.EditValue = null;
            this.cbDob.Location = new System.Drawing.Point(206, 145);
            this.cbDob.Margin = new System.Windows.Forms.Padding(4);
            this.cbDob.Name = "cbDob";
            this.cbDob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDob.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDob.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cbDob.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbDob.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.cbDob.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbDob.Properties.MaskSettings.Set("mask", "");
            this.cbDob.Size = new System.Drawing.Size(161, 34);
            this.cbDob.TabIndex = 6;
            this.cbDob.EditValueChanged += new System.EventHandler(this.cbDob_EditValueChanged);
            // 
            // AddStudentsForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 496);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AddStudentsForm.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Học Viên";
            this.Load += new System.EventHandler(this.AddAccounts_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddAccounts_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lbcFullName;
        private DevExpress.XtraEditors.LabelControl lbcGender;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl lbcDob;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lbcPhoneNumber;
        private DevExpress.XtraEditors.DateEdit cbDob;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lbcAddress;
        private DevExpress.XtraEditors.ComboBoxEdit cbClass;
        private DevExpress.XtraEditors.LabelControl lbcClass;
        private DevExpress.XtraEditors.LabelControl lbcEmail;
        private DevExpress.XtraEditors.LabelControl lbcID;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}