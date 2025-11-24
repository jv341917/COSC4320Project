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
        public SelectedCarForm()
        {
            InitializeComponent();
        }

        #region Switch Screen
        //Switch to "DispenseForm"
        private void backButton_Click(object sender, EventArgs e)
        {
            DispenseForm dispenseScreen = new DispenseForm();
            dispenseScreen.Dock = DockStyle.Fill;
            dispenseScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(dispenseScreen);
            dispenseScreen.Show();

            this.Close();
        }
        //Switch to "DispensedXForm"
        private void dispenseButton_Click(object sender, EventArgs e)
        {
            DispensedXForm dispensedXScreen = new DispensedXForm();
            dispensedXScreen.Dock = DockStyle.Fill;
            dispensedXScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(dispensedXScreen);
            dispensedXScreen.Show();

            this.Close();
        }
        #endregion

        //Modify carLabel so "Spot" & "Car Name" = actual spot and name
        //Modify minLabel so "X" = actual time
        //Modify stage, cooler, & freezerLabels so "#" = spot #
        //Modify toteLabels so "#" = amt of totes
        //Modify timeLabel so "00:00" = changed time
    }
}
