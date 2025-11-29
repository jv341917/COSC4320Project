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
    public partial class OverviewForm : Form
    {
        public static OverviewForm overviewScreen = new OverviewForm();          //Allows other screens to access OverviewForm

        //Constructor
        public OverviewForm()
        {
            InitializeComponent();
            setUser();                      //Sets name on label
        }

        #region Screen Switches

        //Switches to "DispenseForm" & updates the clock in MainForm
        private void switchDispenseButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            DispenseForm.dispenseScreen.updateScreen();

            DispenseForm.dispenseScreen.Dock = DockStyle.Fill;
            DispenseForm.dispenseScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(DispenseForm.dispenseScreen);
            DispenseForm.dispenseScreen.Show();
        }
        //Switches to "PickForm" & updates the clock in MainForm
        private void switchPickButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickForm.pickScreen.updateScreen();

            PickForm.pickScreen.Dock = DockStyle.Fill;
            PickForm.pickScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickForm.pickScreen);
            PickForm.pickScreen.Show();
        }
        //Switches to "EmployeesForm" & updates the clock in MainForm
        private void employeesButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            EmployeesForm.employeeScreen.updateScreen();

            EmployeesForm.employeeScreen.Dock = DockStyle.Fill;
            EmployeesForm.employeeScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(EmployeesForm.employeeScreen);
            EmployeesForm.employeeScreen.Show();
        }
        //Switches to "RemainingPicksForm" & updates the clock in MainForm
        private void remainingPicksButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            RemainingPicksForm.remPicksScreen.updateScreen();

            RemainingPicksForm.remPicksScreen.Dock = DockStyle.Fill;
            RemainingPicksForm.remPicksScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(RemainingPicksForm.remPicksScreen);
            RemainingPicksForm.remPicksScreen.Show();
        }
        //Logs User out of application
        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogoutForm logoutScreen = new LogoutForm();
            logoutScreen.Dock = DockStyle.Fill;
            logoutScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(logoutScreen);
            logoutScreen.Show();

            this.Close();                                        //Screen is never accessed again throughout program
        }
        #endregion

        //Modify timeLabel so "00:00" changes with each time change
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
        }
        //Setter function - Modify userNameLabel so X = userName
        private void setUser()
        {
            userNameLabel.Text = "Hi, " + LoginForm.loginScreen.getUserName();
        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {

        }

        //TO DO : 
        //          Modify dispenseQueueLabel so "#" = dispense queue amount
        //          Modify hourPicksLabel so "#" = remaining picks for the hour

        //Same switch button as screen doesn't do anything - Made to prevent an error 
        //private void switchOverviewButton_Click(object sender, EventArgs e)
        //{
        //    //Do nothing
        //}
    }
}
