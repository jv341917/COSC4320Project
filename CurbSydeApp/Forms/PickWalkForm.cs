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
    public partial class PickWalkForm : Form
    {
        public static PickWalkForm pickWalkScreen = new PickWalkForm();    //Allows other screens to access PickWalkForm
        private int category; // General, Cooled, Frozen
        private int givenAmt;   // Amount assigned to user                                        
        //private int totalAmt;  // Total category amount
        //private int indexInArray;
        private Random ranNum; 

        //Constructor
        public PickWalkForm()
        {
            InitializeComponent();
            //change once pickHourArray is ready
            category = 0;
            givenAmt = 0;                          //Initializes
            //totalAmt = 0;                          //Initializes
            ranNum = new Random();
        }

        //public void SetDepartment(string dep)
        //{
        //    category = dep;
        //}
        //Modify timeLabel "00:00" = changes to time & Modify categoryLabel "X" = category
        public void updateScreen(int i, int index)
        {
            //indexInArray = index;
            timeLabel.Text = MainForm.mainScreen.formatClock();

            //int currentHr = MainForm.mainScreen.getClock() / 100;
            //PickHour? hourData = MainForm.mainScreen.pickHours
            //    .FirstOrDefault(p => p.hour == currentHr);

            //if (!hourData.HasValue) return;

            //walkAmtLabel.Text = $"{hourData.Value.total}";
            category = i;

            switch (i)
            {
                case 0:
                    categoryLabel.Text = "General";
                    givenAmt = ranNum.Next(MainForm.mainScreen.pickHours[index].genAmt) + 1;
                    walkAmtLabel.Text = givenAmt + " / " + MainForm.mainScreen.pickHours[index].genAmt;
                    break;
                case 1:
                    categoryLabel.Text = "Cooled";
                    givenAmt = ranNum.Next(MainForm.mainScreen.pickHours[index].coolAmt) + 1;
                    walkAmtLabel.Text = givenAmt + " / " + MainForm.mainScreen.pickHours[index].coolAmt;
                    break;
                case 2:
                    categoryLabel.Text = "Frozen";
                    givenAmt = ranNum.Next(MainForm.mainScreen.pickHours[index].frozenAmt) + 1;
                    walkAmtLabel.Text = givenAmt + " / " + MainForm.mainScreen.pickHours[index].frozenAmt;
                    break;
            }
        }
        //Switches to "PickForm" & updates the clock in MainForm
        private void backButton_Click(object sender, EventArgs e)
        {
            PickForm.pickScreen.deductAmt(givenAmt, category);
            MainForm.mainScreen.updateClock(givenAmt / 2);
            PickForm.pickScreen.updateScreen();

            PickForm.pickScreen.Dock = DockStyle.Fill;
            PickForm.pickScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickForm.pickScreen);
            PickForm.pickScreen.Show();

            //Perform respective pick amount deductions
        }

        private void PickWalkForm_Load(object sender, EventArgs e)
        {

        }

        //TO DO :
        //          Modify walkAmtLabel "Y" = given amt & "X" = total category amt
    }
}
