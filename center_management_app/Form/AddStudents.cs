using System;
using System.Linq;
using System.Windows.Forms;
using center_management_app.Services.models;
using DevExpress.XtraEditors;
using center_management_app.Services;

namespace center_management_app.Forms
{
    public partial class AddStudentsForm : XtraForm
    {
        public AddStudentsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void AddAccounts_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddAccounts_Load(object sender, EventArgs e)
        {
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
            // Thực thi khi Button được nhấp
            string name = txtFullName.Text.Trim();
            string gender = cbGender.Text;
            DateTime dob = cbDob.DateTime;
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            Class selectedClass = cbClass.SelectedItem as Class;
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

            //public Student(string fullName, string gender, DateTime dob, string phoneNumber, string email, string address, Class @class)
            Student newStudent = new Student(name, gender, dob, phoneNumber, email, address, selectedClass);

            //StudentService.Add(newStudent);

            DialogResult result = MessageBox.Show(newStudent.ToString());

            if (result == DialogResult.OK)
            {
                // Đóng form hiện tại
                this.Close();
            }
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
    }
}