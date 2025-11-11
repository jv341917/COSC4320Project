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
        public OverviewForm()
        {
            InitializeComponent();
        }
        #region Screen Switches
        //Same switch button as screen doesn't do anything
        private void switchOverviewButton_Click(object sender, EventArgs e)
        {
            //Do nothing
        }
        //Switches to "DispenseForm"
        private void switchDispenseButton_Click(object sender, EventArgs e)
        {
            DispenseForm dispenseScreen = new DispenseForm();
            dispenseScreen.Dock = DockStyle.Fill;
            dispenseScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(dispenseScreen);
            dispenseScreen.Show();

            this.Close();
        }
        //Switches to "PickForm"
        private void switchPickButton_Click(object sender, EventArgs e)
        {
            PickForm pickScreen = new PickForm();
            pickScreen.Dock = DockStyle.Fill;
            pickScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(pickScreen);
            pickScreen.Show();

            this.Close();
        }
        //Switches to "EmployeesForm"
        private void employeesButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesScreen = new EmployeesForm();
            employeesScreen.Dock = DockStyle.Fill;
            employeesScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(employeesScreen);
            employeesScreen.Show();

            this.Close();
        }
        //Switches to "RemainingPicksForm"
        private void remainingPicksButton_Click(object sender, EventArgs e)
        {
            RemainingPicksForm remPicksScreen = new RemainingPicksForm();
            remPicksScreen.Dock = DockStyle.Fill;
            remPicksScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(remPicksScreen);
            remPicksScreen.Show();

            this.Close();
        }
        #endregion
        //Modify userNameLabel so X = userName
        //Modify dispenseQueueLabel so "#" = dispense queue amount
        //Modify hourPicksLabel so "#" = remaining picks for the hour
        //Modify timeLabel so "00:00" changes with each time change
    }
}
