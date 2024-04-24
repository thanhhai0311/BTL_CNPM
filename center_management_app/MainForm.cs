using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;
using center_management_app.Services;
using center_management_app.Services.models;
using center_management_app.Components;
using DevExpress.XtraPrinting;
using center_management_app.Forms;
using DevExpress.LookAndFeel;

namespace center_management_app
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }
        public static MainForm instance { get; set; }

        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainForm();
                return instance;
            }
        }
        private void ChangeBodyControl(UserControl us)
        {
            bodyControl.Controls.Clear();
            us.Dock = DockStyle.Fill;
            bodyControl.Controls.Add(us);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeBodyControl(UCAccountManager.Instance);
        }

        private void btnAddStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddStudentsForm addAccount = new AddStudentsForm();
            addAccount.ShowDialog();
        }

        private void btnClasses_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddClassesForm addGroup = new AddClassesForm();
            addGroup.ShowDialog();
        }

        
        private void ribbonControl_PaddingChanged(object sender, EventArgs e)
        {
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {
            switch (ribbonControl.SelectedPage.Text)
            {
                case "Home":
                    ChangeBodyControl(UCAccountManager.Instance);
                    break;
            }
        }


        private void btnExportData_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void tsTheme_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!tsTheme.Checked)
            {
               DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.Calmness);
                tsTheme.Caption = "Light  ";
            }
            else
            {

                tsTheme.Caption = "Dark  ";
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.Darkness);
            }
        }

        private void tsTheme_CheckedChanged(object sender, ItemClickEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}