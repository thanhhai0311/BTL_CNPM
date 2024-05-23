using System;
using System.Linq;
using System.Windows.Forms;
using center_management_app.Services.models;
using DevExpress.XtraEditors;
using center_management_app.Services;
using System.Collections.Generic;
using center_management_app.Components;

namespace center_management_app.Forms
{
    public partial class EditStudent : XtraForm
    {
        private string id_class = "0";
        private string name_class = "english";
        public EditStudent()
        {
            InitializeComponent();
            this.txtID.Text = Convert.ToString(StudentService.getMaxID() + 1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void AddAccounts_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddAccounts_Load(object sender, EventArgs e)
        {
            var allClasses = ClassService.GetAll();

            foreach (var _class in allClasses)
            {
                cbClass.Properties.Items.Add(_class);
            }

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Thực thi khi Button được nhấp
            this.Close();
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void lbcName_Click(object sender, EventArgs e)
        {

        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Thực thi khi Button được nhấp
            string id = this.txtID.Text.Trim();
            string name = this.txtFullName.Text.Trim();
            string gender = this.cbGender.Text;
            DateTime dob = this.cbDob.DateTime;
            string phoneNumber = this.txtPhoneNumber.Text.Trim();
            string address = this.txtAddress.Text.Trim();
            string email = this.txtEmail.Text.Trim();
            List<Class> cls = ClassService.FindByName(cbClass.SelectedItem.ToString());
            Class selectedClass = cls[0];

            // Kiểm tra các trường dữ liệu
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên học viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L} ]+$"))
            {
                MessageBox.Show("Tên học viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (string.IsNullOrEmpty(phoneNumber) || !phoneNumber.All(char.IsDigit) || phoneNumber.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains('@'))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            Student newStudent = new Student(name, gender, dob, phoneNumber, email, address, selectedClass);
            newStudent.ID = id;

            MessageBox.Show(newStudent.ToString(), "Xác Nhận Thông Tin!!");

            bool result = StudentService.Update(newStudent);
            //MessageBox.Show(result.ToString());


            DialogResult result1;

            if (result)
            {
                UCAccountManager.Instance.LoadData();
                result1 = MessageBox.Show("Sửa học viên thành công!");
                //this.Close();
                if (result1 == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void cbDob_EditValueChanged(object sender, EventArgs e)
        {

        }

        public void SetButtonName(string newName)
        {
            btnAdd.Text = newName;
        }

        public EditStudent(Student student)
        {
            InitializeComponent();
            this.txtID.Text = student.ID.ToString();
            this.txtFullName.Text = student.fullName;
            this.cbGender.Text = student.gender.ToString();
            this.cbDob.EditValue = Convert.ToDateTime(student.dob);
            this.txtPhoneNumber.Text = student.phoneNumber;
            this.txtAddress.Text = student.address;
            this.txtEmail.Text = student.email;
            this.cbClass.EditValue = student._class.Name;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.id_class = student._class.ID;
            this.name_class = student._class.Name;
            this.MaximizeBox = false;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbcDob_Click(object sender, EventArgs e)
        {

        }

        private void lbcGender_Click(object sender, EventArgs e)
        {

        }

        //private void LoadClassesIntoComboBox()
        //{
        //    try
        //    {
        //        List<Class> classList = ClassService.GetAll(0, 10000); // Giả sử lấy tất cả lớp học
        //        cbClass.Properties.Items.AddRange(classList.ToArray());


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message);
        //    }
        //} 
    }
}