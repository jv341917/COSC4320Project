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
        public DispenseForm()
        {
            InitializeComponent();
        }
        #region Screen Switches
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
        //Same switch button as screen doesn't do anything
        private void switchDispenseButton_Click(object sender, EventArgs e)
        {
            //Do nothing
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
        //Switch to "SelectedCarForm"
        private void carButton1_Click(object sender, EventArgs e)
        {
            SelectedCarForm selectScreen = new SelectedCarForm();
            selectScreen.Dock = DockStyle.Fill;
            selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(selectScreen);
            selectScreen.Show();

            this.Close();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton2_Click(object sender, EventArgs e)
        {
            SelectedCarForm selectScreen = new SelectedCarForm();
            selectScreen.Dock = DockStyle.Fill;
            selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(selectScreen);
            selectScreen.Show();

            this.Close();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton3_Click(object sender, EventArgs e)
        {
            SelectedCarForm selectScreen = new SelectedCarForm();
            selectScreen.Dock = DockStyle.Fill;
            selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(selectScreen);
            selectScreen.Show();

            this.Close();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton4_Click(object sender, EventArgs e)
        {
            SelectedCarForm selectScreen = new SelectedCarForm();
            selectScreen.Dock = DockStyle.Fill;
            selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(selectScreen);
            selectScreen.Show();

            this.Close();

            //calls car function & passes Car
        }
        //Switch to "SelectedCarForm"
        private void carButton5_Click(object sender, EventArgs e)
        {
            SelectedCarForm selectScreen = new SelectedCarForm();
            selectScreen.Dock = DockStyle.Fill;
            selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(selectScreen);
            selectScreen.Show();

            this.Close();

            //calls car function & passes Car
        }
        #endregion
        //Modify the buttons & labels to correctly display the spot, name, and time with each car
        //          if there aren't enough cars in queue for the buttons, hide the unused buttons
        //Modify timeLabel "00:00" = changes to time
    }
}
