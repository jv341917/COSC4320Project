using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurbSydeApp.Forms
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }
        //Switches to "OverviewForm"
        private void backButton_Click(object sender, EventArgs e)
        {
            OverviewForm overviewScreen = new OverviewForm();
            overviewScreen.Dock = DockStyle.Fill;
            overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(overviewScreen);
            overviewScreen.Show();

            this.Close();
        }
        //Modify each label so "Name" = employee name, "Activity" = activity, & labels disappear if an employee isn't clocked in
        //Modify timeLabel so "00:00" changes with each time change
    }
}
