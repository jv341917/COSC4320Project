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
    public partial class RemainingPicksForm : Form
    {
        public static RemainingPicksForm remPicksScreen = new RemainingPicksForm();       //Allows other screens to access RemainingPicksForm

        //Constructor
        public RemainingPicksForm()
        {
            InitializeComponent();
        }
        //Switches to "OverviewForm" & updates clock in MainForm
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            OverviewForm.overviewScreen.updateScreen();

            OverviewForm.overviewScreen.Dock = DockStyle.Fill;
            OverviewForm.overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(OverviewForm.overviewScreen);
            OverviewForm.overviewScreen.Show();
        }
        //Modify timeLabel so "00:00" changes with each time change
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
        }

        //TO DO : 
        //          Modify currentLabel so "#" shows current amount of picks in system
        //          Modify remainingLabel so "#" shows total remaining amount of picks for the day
        //          Modify the hour labels so "Hour" = "1-2pm", etc & "#" = corresponding amount for that hour
        //          Modify completedLabel so "#" = total amount of picks completed for the day
        
    }
}
