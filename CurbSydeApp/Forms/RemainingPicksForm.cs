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
        public RemainingPicksForm()
        {
            InitializeComponent();
        }
        //Switches to "OverviewForm"
        private void backButton_Click(object sender, EventArgs e)
        {
            OverviewForm overviewScreen = new OverviewForm();
            overviewScreen.Dock = DockStyle.Fill;
            overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(overviewScreen);
            overviewScreen.Show();

            this.Close();
        }
        //Modify currentLabel so "#" shows current amount of picks in system
        //Modify remainingLabel so "#" shows total remaining amount of picks for the day
        //Modify the hour labels so "Hour" = "1-2pm", etc & "#" = corresponding amount for that hour
        //Modify completedLabel so "#" = total amount of picks completed for the day
        //Modify timeLabel so "00:00" changes with each time change
    }
}
