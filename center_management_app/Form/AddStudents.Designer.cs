using center_management_app.Services.models;
using System;
using System.Linq;
using System.Windows.Forms;

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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbDob = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialog
            // 
            this.xtraOpenFileDialog.FileName = "xtraOpenFileDialog1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 347);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(491, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(272, 13);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(118, 31);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Thêm";
            this.simpleButton2.Click += simpleButton2_Click;
            void simpleButton2_Click(object sender, EventArgs e)
            {
                // Thực thi khi Button được nhấp
                string name = txtFullName.Text;
                string gender = cbGender.Text;
                DateTime dob = cbDob.DateTime;
                string phoneNumber = txtPhoneNumber.Text;
                string address = txtAddress.Text;
                Class selectedClass = comboBoxEdit2.SelectedItem as Class;
                //string lop = comboBoxEdit2.SelectedItem.ToString();
                //MessageBox.Show(lop);
                //public Student(string phoneNumber, string fullName, string gender, string address, DateTime dob, Class @class)
                //MessageBox.Show(selectedClass.ToString());
                // Kiểm tra các trường dữ liệu
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Tên học viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(gender) || (gender != "Nam" && gender != "Nữ"))
                {
                    MessageBox.Show("Giới tính không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dob == DateTime.MinValue)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(phoneNumber) || !phoneNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Địa chỉ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClass == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Student newStudent = new Student(phoneNumber, name, gender, address, dob, selectedClass);

                DialogResult result = MessageBox.Show(newStudent.ToString());
                if (result == DialogResult.OK)
                {
                    // Đóng form hiện tại
                    this.Close();
                }
            }
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(89, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 31);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Hủy";
            this.simpleButton1.Click += simpleButton1_Click;
            void simpleButton1_Click(object sender, EventArgs e)
            {
                // Thực thi khi Button được nhấp
                this.Close();
            }
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.comboBoxEdit2);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.txtAddress);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtPhoneNumber);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.cbGender);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtFullName);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.cbDob);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(491, 347);
            this.panelControl2.TabIndex = 1;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(177, 237);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            Class lop1 = new Class("Tiếng Anh 1");
            Class lop2 = new Class("Tiếng Anh 2");
            Class lop3 = new Class("Tiếng Anh 3");
            Class lop4 = new Class("Tiếng Trung 1");
            Class lop5 = new Class("Tiếng Trung 2");
            //this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            //"Tiếng Anh 1",
            //"Tiếng Anh 2",
            //"Tiếng Anh 3",
            //"Tiếng Trung 1",
            //"Tiếng Trung 2"});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            lop1,
            lop2, 
            lop3, 
            lop4, 
            lop5
            });
            this.comboBoxEdit2.Size = new System.Drawing.Size(234, 28);
            this.comboBoxEdit2.TabIndex = 14;
            comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(59, 244);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Lớp Học";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(177, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 28);
            this.txtAddress.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 198);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Địa Chỉ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(177, 147);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPhoneNumber.Size = new System.Drawing.Size(138, 28);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(59, 154);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Số Điện Thoại";
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(177, 60);
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Size = new System.Drawing.Size(138, 28);
            this.cbGender.TabIndex = 5;
            cbGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(59, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ngày Sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Giới Tính";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(177, 17);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(234, 28);
            this.txtFullName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Học Viên";
            // 
            // cbDob
            // 
            this.cbDob.EditValue = new System.DateTime(2024, 4, 24, 18, 56, 11, 0);
            this.cbDob.Location = new System.Drawing.Point(177, 103);
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
            this.cbDob.Size = new System.Drawing.Size(138, 28);
            this.cbDob.TabIndex = 6;
            // 
            // AddStudentsForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 403);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AddStudentsForm.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDob.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit cbDob;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}