using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using center_management_app.Properties;
using center_management_app.Services;
using center_management_app.Services.models;
using DevExpress.XtraEditors;
using center_management_app.Services;
using center_management_app.Forms;
using DevExpress.XtraRichEdit.Model;
using center_management_app.Form;


namespace center_management_app.Components
{
    public partial class UCAccountManager : XtraUserControl
    {
        private static UCAccountManager _Instance;

        public DataTable tableDataSource = new DataTable();

        public UCAccountManager()
        {
            InitializeComponent();
            TableInit();
            _Instance = this;
            LoadData();
        }


        public static UCAccountManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UCAccountManager { Dock = DockStyle.Fill };
                return _Instance;
            }
        }

        private void TableInit()
        {
            tableDataSource.Columns.AddRange(new[]
            {
                new DataColumn(nameof(cNumber), typeof(int)),
                new DataColumn(nameof(cName), typeof(string)),
                new DataColumn(nameof(cPhoneNumber), typeof(string)),
                new DataColumn(nameof(cGender), typeof(string)),
                new DataColumn(nameof(cDob), typeof(string)),
                new DataColumn(nameof(cStatus), typeof(string)),
            });

            gridAccount.DataSource = tableDataSource;
        }

        public void AddStudent(Student stu)
        {
            DataRow newRow = tableDataSource.NewRow();
            newRow["cNumber"] = stu.ID;
            newRow["cName"] = stu.fullName;
            newRow["cPhoneNumber"] = stu.phoneNumber;
            newRow["cGender"] = stu.gender;
            newRow["cDob"] = stu.dob.ToString("dd/MM/yyyy");
            newRow["cStatus"] = stu._class.Name;
            tableDataSource.Rows.Add(newRow);
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableDataSource.Clear();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

       public void LoadData()
        {
            tableDataSource.Clear();
            int sl = StudentService.getSize();
            List<Student> list = StudentService.GetAll(0, 100000);
            foreach (Student stu in list)
            {
                AddStudent(stu);
            }
            gridAccount.Refresh();
        }


        private void MenuItemClickHandler(object sender, EventArgs e)
        {
        }

        private void menuAccount_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }


        private void gridAccount_Click(object sender, EventArgs e)
        {

        }

        private void EditInfotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var selected = gridView1.GetSelectedRows();
            if (selected.Length == 1)
            {
                DataRowView row = (DataRowView)gridView1.GetRow(selected[0]);
                var studentID = row[nameof(cNumber)].ToString();
                if (!String.IsNullOrEmpty(studentID))
                {
                    // student in database
                    var AddForm = new AddStudentsForm();
                    AddForm.Text = "Chỉnh sửa thông tin học viên";
                    AddForm.SetButtonName("Lưu");
                    var list = StudentService.FindByID(studentID);
                    var st = list[0];
                    MessageBox.Show(st.ToString());
                    var addForm = new AddStudentsForm(st);
                    AddForm.ShowDialog();
                    

                }
            }
            else
            {
                MessageBox.Show("Chọn 1 học viên để chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var selected = gridView1.GetSelectedRows();
            //bool check = true;
            //for(int i=0; i<selected.Length; i++)
            //{
            //    var studentId = Convert.ToInt32(gridView1.GetRowCellValue(selected[i], "cNumber"));
            //    //MessageBox.Show(studentId.ToString());
            //    check = StudentService.Delete(studentId);
            //    if(!check)
            //    {
            //        break;
            //    }
            //}
            //if (check)
            //{
            //    LoadData();
            //    MessageBox.Show("Xóa thành công!");
            //}
            //else
            //{
            //    MessageBox.Show("Xóa không thành công!");
            //}
            var selected = gridView1.GetSelectedRows();
            if (selected.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một học viên để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi người dùng có chắc chắn muốn xóa không
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các học viên đã chọn không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool check = true;
                foreach (int rowIndex in selected)
                {
                    var studentId = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "cNumber"));
                    check = StudentService.Delete(studentId);
                    if (!check)
                    {
                        MessageBox.Show("Xóa không thành công tại ID: " + studentId, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (check)
                {
                    LoadData();
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hành động xóa đã bị hủy.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}