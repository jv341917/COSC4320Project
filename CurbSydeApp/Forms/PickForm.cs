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
    public partial class PickForm : Form
    {
        public PickForm()
        {
            InitializeComponent();
        }
        #region Screen Switches
        //Switches to "PickWalkForm"
        private void generalButton_Click(object sender, EventArgs e)
        {
            PickWalkForm pickWalkScreen = new PickWalkForm();
            pickWalkScreen.Dock = DockStyle.Fill;
            pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(pickWalkScreen);
            pickWalkScreen.Show();

            this.Close();

            //call pickwalk function to change "X" to "General"
        }
        //Switches to "PickWalkForm"
        private void cooledButton_Click(object sender, EventArgs e)
        {
            PickWalkForm pickWalkScreen = new PickWalkForm();
            pickWalkScreen.Dock = DockStyle.Fill;
            pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(pickWalkScreen);
            pickWalkScreen.Show();

            this.Close();

            //call pickwalk function to change "X" to "Cooled"
        }
        //Switches to "PickWalkForm"
        private void frozenButton_Click(object sender, EventArgs e)
        {
            PickWalkForm pickWalkScreen = new PickWalkForm();
            pickWalkScreen.Dock = DockStyle.Fill;
            pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(pickWalkScreen);
            pickWalkScreen.Show();

            this.Close();

            //call pickwalk function to change "X" to "Frozen"
        }
        //Same switch button as screen doesn't do anything
        private void switchPickButton_Click(object sender, EventArgs e)
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
        //Switches to "OverviewForm"
        private void switchOverviewButton_Click(object sender, EventArgs e)
        {
            OverviewForm overviewScreen = new OverviewForm();
            overviewScreen.Dock = DockStyle.Fill;
            overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(overviewScreen);
            overviewScreen.Show();

            this.Close();
        }
        #endregion 

        //Modify timeLabel so "00:00" changes when time changes
        //Modify button labels so "#" corresponds to the amount of items per category
    }
}
