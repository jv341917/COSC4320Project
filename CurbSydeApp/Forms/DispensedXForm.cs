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
    public partial class DispensedXForm : Form
    {
        public static DispensedXForm dispensedXScreen = new DispensedXForm();         //Allows other screens to access DispensedXForm

        //Constructor
        public DispensedXForm()
        {
            InitializeComponent();
        }
        //Switch to "DispenseForm" & updates the clock in MainForm
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(2);
            DispenseForm.dispenseScreen.updateScreen();

            DispenseForm.dispenseScreen.Dock = DockStyle.Fill;
            DispenseForm.dispenseScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(DispenseForm.dispenseScreen);
            DispenseForm.dispenseScreen.Show();
        }
        //Modify timeLabel so "00:00" = changed time
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
        }

        //TO DO : 
        //          Modify carLabel so it reflects the car name
        //          set time in car to 0 & 
    }
}
