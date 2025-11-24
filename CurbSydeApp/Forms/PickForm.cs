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
        public static PickForm pickScreen = new PickForm();       //Allows other screens to access PickForm

        //Constructor
        public PickForm()
        {
            InitializeComponent();
        }
        #region Screen Switches
        //Switches to "PickWalkForm" & updates the clock in MainForm
        private void generalButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickWalkForm.pickWalkScreen.updateScreen();

            PickWalkForm.pickWalkScreen.Dock = DockStyle.Fill;
            PickWalkForm.pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickWalkForm.pickWalkScreen);
            PickWalkForm.pickWalkScreen.Show();

            //call pickwalk function to change "X" to "General"
        }
        //Switches to "PickWalkForm" & updates the clock in MainForm
        private void cooledButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickWalkForm.pickWalkScreen.updateScreen();

            PickWalkForm.pickWalkScreen.Dock = DockStyle.Fill;
            PickWalkForm.pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickWalkForm.pickWalkScreen);
            PickWalkForm.pickWalkScreen.Show();

            //call pickwalk function to change "X" to "Cooled"
        }
        //Switches to "PickWalkForm" & updates the clock in MainForm
        private void frozenButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickWalkForm.pickWalkScreen.updateScreen();

            PickWalkForm.pickWalkScreen.Dock = DockStyle.Fill;
            PickWalkForm.pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickWalkForm.pickWalkScreen);
            PickWalkForm.pickWalkScreen.Show();

            //call pickwalk function to change "X" to "Frozen"
        }
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
        //Switches to "OverviewForm" & updates the clock in MainForm
        private void switchOverviewButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            OverviewForm.overviewScreen.updateScreen();

            OverviewForm.overviewScreen.Dock = DockStyle.Fill;
            OverviewForm.overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(OverviewForm.overviewScreen);
            OverviewForm.overviewScreen.Show();
        }
        #endregion 

        
        //Modify timeLabel so "00:00" changes when time changes
        //Modify button labels so "#" corresponds to the amount of items per category
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
        }

        ////Same switch button as screen doesn't do anything
        //private void switchPickButton_Click(object sender, EventArgs e)
        //{
        //    //Do nothing
        //}
    }
}
