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
        public DispensedXForm()
        {
            InitializeComponent();
        }
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
        //Modify timeLabel so "00:00" = changed time
        //Modify carLabel so it reflects the car name
    }
}
