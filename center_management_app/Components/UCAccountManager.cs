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

        public void AddStudent(int number, string name, string phoneNumber, string gender, string dob, string status)
        {
            DataRow newRow = tableDataSource.NewRow();
            newRow["cNumber"] = number;
            newRow["cName"] = name;
            newRow["cPhoneNumber"] = phoneNumber;
            newRow["cGender"] = gender;
            newRow["cDob"] = dob;
            newRow["cStatus"] = status;
            tableDataSource.Rows.Add(newRow);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent(1, "Nguyen Van A", "0123456789", "Nam", "01/01/1990", "Active");
        }

        //AddStudent(1, "Hải", "0967726885", "Nam", "2003", "Có");
   


        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableDataSource.Clear();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //AddStudent(1, "Nguyen Van A", "0123456789", "Nam", "01/01/1990", "Active");
            //gridAccount.Refresh();
            List<Student> a = StudentService.GetAll();
            MessageBox.Show(a[0].fullName);

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

    }
}