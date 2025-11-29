using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int genClosestIndex;
        private int cooledClosestIndex;
        private int frozenClosestIndex;

        //Constructor
        public PickForm()
        {
            InitializeComponent();
            genClosestIndex = 0;
            cooledClosestIndex = 0;
            frozenClosestIndex = 0;
        }
        #region Screen Switches
        //Switches to "PickWalkForm" & updates the clock in MainForm
        private void generalButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickWalkForm.pickWalkScreen.updateScreen(0, genClosestIndex);

            PickWalkForm.pickWalkScreen.Dock = DockStyle.Fill;
            PickWalkForm.pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickWalkForm.pickWalkScreen);
            PickWalkForm.pickWalkScreen.Show();
        }
        //Switches to "PickWalkForm" & updates the clock in MainForm
        private void cooledButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickWalkForm.pickWalkScreen.updateScreen(1, cooledClosestIndex);

            PickWalkForm.pickWalkScreen.Dock = DockStyle.Fill;
            PickWalkForm.pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickWalkForm.pickWalkScreen);
            PickWalkForm.pickWalkScreen.Show();
        }
        //Switches to "PickWalkForm" & updates the clock in MainForm
        private void frozenButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickWalkForm.pickWalkScreen.updateScreen(2, frozenClosestIndex);

            PickWalkForm.pickWalkScreen.Dock = DockStyle.Fill;
            PickWalkForm.pickWalkScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickWalkForm.pickWalkScreen);
            PickWalkForm.pickWalkScreen.Show();
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

        //finds the index of the array with picks still in system
        private int determineIndex(int cat)
        {
            
            for(int i = 0; i < MainForm.mainScreen.pickHours.Length; i++)
            {
                switch (cat)
                {
                    case 0:
                        if (MainForm.mainScreen.pickHours[i].genAmt > 0)
                        {
                            return i;
                        }
                        break;
                    case 1:
                        if (MainForm.mainScreen.pickHours[i].coolAmt > 0)
                        {
                            return i;
                        }
                        break;
                    case 2:
                        if (MainForm.mainScreen.pickHours[i].frozenAmt > 0)
                        {
                            return i;
                        }
                        break;
                }
            }

            return 0;
        }
        //removes the amt given to the user in a pick walk from the total and corresponding category from pickHourArray
        public void deductAmt(int amt, int category)
        {
            switch (category)
            {
                case 0:
                    MainForm.mainScreen.pickHours[genClosestIndex].genAmt -= amt;
                    MainForm.mainScreen.pickHours[genClosestIndex].total -= amt;
                    break;
                case 1:
                    MainForm.mainScreen.pickHours[cooledClosestIndex].coolAmt -= amt;
                    MainForm.mainScreen.pickHours[cooledClosestIndex].total -= amt;
                    break;
                case 2:
                    MainForm.mainScreen.pickHours[frozenClosestIndex].frozenAmt -= amt;
                    MainForm.mainScreen.pickHours[frozenClosestIndex].total -= amt;
                    break;
            }
        }
        //Modify timeLabel so "00:00" changes when time changes
        //Modify button labels so "#" corresponds to the amount of items per category
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
            genClosestIndex = determineIndex(0);
            cooledClosestIndex = determineIndex(1);
            frozenClosestIndex = determineIndex(2);

            var data = MainForm.mainScreen.pickHours;

            if (data == null || data.Length == 0)
            {
                Debug.WriteLine("PickHours array is EMPTY!");
                generalButton.Text = "GENERAL   0";
                generalButton.Visible = false;
                cooledButton.Text = "COOLED    0";
                cooledButton.Visible = false;
                frozenButton.Text = "FROZEN    0";
                frozenButton.Visible = false;
                return;
            }

            int currentHr = MainForm.mainScreen.getClock() / 100;       // Determines current hour
            int index = currentHr - 5;

            if (index < 0 || index >= data.Length)
            {
                Debug.WriteLine($"Hour {currentHr} not in range.");
                generalButton.Text = "GENERAL   0";
                generalButton.Visible = false;
                cooledButton.Text = "COOLED    0";
                cooledButton.Visible = false;
                frozenButton.Text = "FROZEN    0";
                frozenButton.Visible = false;
                return;
            }

            //PickHour hour = data[index];
            int genSum = 0;
            int coolSum = 0;
            int frozenSum = 0;
            for(int i = 0; i <= index; i++)
            {
                genSum += data[i].genAmt;
                coolSum += data[i].coolAmt;
                frozenSum += data[i].frozenAmt;
            }

            if(genSum == 0)
            {
                generalButton.Visible = false;
            }
            else
            {
                generalButton.Visible = true;
                generalButton.Text = "GENERAL   " + genSum;
            }
            
            if(coolSum == 0)
            {
                cooledButton.Visible = false;
            }
            else
            {
                cooledButton.Visible = true;
                cooledButton.Text = "COOLED    " + coolSum;
            }

            if (frozenSum == 0)
            {
                frozenButton.Visible = false;
            }
            else
            {
                frozenButton.Visible = true;
                frozenButton.Text = "FROZEN    " + frozenSum;
            }
        }


        private void PickForm_Load(object sender, EventArgs e)
        {

        }
    }
}
