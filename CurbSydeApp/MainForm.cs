using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurbSydeApp.Forms;

namespace CurbSydeApp
{
    public partial class MainForm : Form
    {
        public static Panel mainPanel;
        public MainForm()
        {
            InitializeComponent();
            mainPanel = panel1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //CORRECT START
            //LoginForm loginScreen = new LoginForm();
            //loginScreen.Dock = DockStyle.Fill;
            //loginScreen.TopLevel = false;
            //panel1.Controls.Clear();
            //panel1.Controls.Add(loginScreen);
            //loginScreen.Show();

            SelectedCarForm overviewScreen = new SelectedCarForm();
            overviewScreen.Dock = DockStyle.Fill;
            overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(overviewScreen);
            overviewScreen.Show();
        }
    }
}
