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
    public partial class SelectedCarForm : Form
    {
        public static SelectedCarForm selectScreen = new SelectedCarForm();         //Allows other screens to access SelectedCarForm

        //Constructor
        public SelectedCarForm()
        {
            InitializeComponent();
        }

        #region Switch Screen
        //Switch to "DispenseForm" & updates the clock in MainForm
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            DispenseForm.dispenseScreen.updateScreen();

            DispenseForm.dispenseScreen.Dock = DockStyle.Fill;
            DispenseForm.dispenseScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(DispenseForm.dispenseScreen);
            DispenseForm.dispenseScreen.Show();
        }
        //Switch to "DispensedXForm" & updates the clock in MainForm
        private void dispenseButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            DispensedXForm.dispensedXScreen.updateScreen();

            DispensedXForm.dispensedXScreen.Dock = DockStyle.Fill;
            DispensedXForm.dispensedXScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(DispensedXForm.dispensedXScreen);
            DispensedXForm.dispensedXScreen.Show();
        }
        #endregion

        //Modify timeLabel so "00:00" = changed time
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
        }

        //TO DO :
        //          Modify carLabel so "Spot" & "Car Name" = actual spot and name
        //          Modify minLabel so "X" = actual time
        //          Modify stage, cooler, & freezerLabels so "#" = spot #
        //          Modify toteLabels so "#" = amt of totes

    }
}
