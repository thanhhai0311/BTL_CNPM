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

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableDataSource.Clear();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
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