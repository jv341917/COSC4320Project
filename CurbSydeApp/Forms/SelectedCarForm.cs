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
        private Random ranNum;                                                      //Stores the random numbers generated for initializations

        //Constructor
        public SelectedCarForm()
        {
            InitializeComponent();
            ranNum = new Random();              //Initializes
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
        public void updateScreen(Car c)
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();

            carLabel.Text = c.spot + " - " + c.name;
            minLabel.Text = c.time + " min";
            stageLabel.Text = "STAGE " + c.stageNum;
            toteLabel1.Text = c.sToteAmt + " totes";
            coolerLabel.Text = "COOLER " + c.coolerNum;
            toteLabel2.Text = c.cToteAmt + " totes";
            freezerLabel.Text = "FREEZER " + c.freezerNum;
            toteLabel3.Text = c.fToteAmt + " totes";
        }

    }
}
