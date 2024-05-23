using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using center_management_app.Services;
using center_management_app.Services.models;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace center_management_app.Forms
{
    public partial class AddClassesForm : XtraForm
    {
        private DataTable _tableDataSource = new DataTable();

        public event EventHandler OnGroupAdded;
        public event EventHandler OnGroupDeleted;

        public AddClassesForm()
        {
            InitializeComponent();
            InitTable();
        }

        private void AddGroups_Paint(object sender, PaintEventArgs e)
        {
        }

        private void InitTable()
        {
            _tableDataSource.Columns.AddRange(new DataColumn[] {
                new DataColumn(nameof(cIndex),typeof(int)),
                new DataColumn(nameof(cClassName),typeof(string)),
                new DataColumn(nameof(cTeacherName),typeof(string)),
                new DataColumn(nameof(cTotal),typeof(string)),
                new DataColumn(nameof(cSubject), typeof(string))
            });
            gcGroups.DataSource = _tableDataSource;
        }

        private void AddClassesForm_Load(object sender, EventArgs e)
        {
        }

        public void LoadGroups()
        {
        }

        public void RefreshTable()
        {
            gcGroups.BeginUpdate();
            _tableDataSource.Clear();
            gcGroups.DataSource = null;
            LoadGroups();
            gcGroups.DataSource = _tableDataSource;
            gcGroups.EndUpdate();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
        }

        private void gvGroups_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void btnDeleteGroup_Click(object sender, ButtonPressedEventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}