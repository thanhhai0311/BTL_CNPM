using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
    }
}