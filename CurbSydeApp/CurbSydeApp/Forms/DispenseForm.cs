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
    public partial class DispenseForm : Form
    {
        public static DispenseForm dispenseScreen = new DispenseForm();         //Allows other screens to access DispenseForm

        //Constructor
        public DispenseForm()
        {
            InitializeComponent();
        }
        #region Screen Switches
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
        //Switch to "SelectedCarForm"
        private void carButton1_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen();

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton2_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen();

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton3_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen();

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton4_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen();

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton5_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen();

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();

            //calls car function & passes Car
        }
        #endregion

        //Modify timeLabel "00:00" = changes to time
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
        }

        //TO DO :  
        //          Modify the buttons & labels to correctly display the spot, name, and time with each car
        //                      if there aren't enough cars in queue for the buttons, hide the unused buttons

        ////Same switch button as screen doesn't do anything
        //private void switchDispenseButton_Click(object sender, EventArgs e)
        //{
        //    //Do nothing
        //}
    }
}
