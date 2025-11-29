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
        public static PickWalkForm pickWalkScreen;    //Allows other screens to access PickWalkForm
        private string category; // General, Cooled, Frozen
        private int givenAmt;   // Amount assigned to user                                        
        private int totalAmt;  // Total category amount                                

        //Constructor
        public PickWalkForm()
        {
            InitializeComponent();
            //change once pickHourArray is ready
            givenAmt = 60;                          //Initializes
            totalAmt = 90;                          //Initializes
        }

        public void SetDepartment (string dep)
        {
            category = dep;
        }

        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();

            int currentHr = MainForm.mainScreen.getClock() / 100;

            PickHour? hourData = MainForm.mainScreen.pickHours
                .FirstOrDefault(p => p.hour == currentHr);

            if (!hourData.HasValue) return;

            walkAmtLabel.Text = $"{hourData.Value.total}";

        }
        //Switches to "PickForm" & updates the clock in MainForm
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(givenAmt / 2);
            PickForm.pickScreen.updateScreen();

            PickForm.pickScreen.Dock = DockStyle.Fill;
            PickForm.pickScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickForm.pickScreen);
            PickForm.pickScreen.Show();

            //Perform respective pick amount deductions
        }
        //Modify timeLabel "00:00" = changes to time


        private void PickWalkForm_Load(object sender, EventArgs e)
        {

        }

        //TO DO :
        //          Modify walkAmtLabel "Y" = given amt & "X" = total category amt
        //          Modify categoryLabel "X" = category
    }
}
