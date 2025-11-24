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
        public PickWalkForm()
        {
            InitializeComponent();
        }
        //Switches to "PickForm"
        private void backButton_Click(object sender, EventArgs e)
        {
            PickForm pickScreen = new PickForm();
            pickScreen.Dock = DockStyle.Fill;
            pickScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(pickScreen);
            pickScreen.Show();

            this.Close();

            //Perform respective pick amount deductions
        }
        //Modify walkAmtLabel "Y" = given amt & "X" = total category amt
        //Modify categoryLabel "X" = category
        //Modify timeLabel "00:00" = changes to time
    }
}
