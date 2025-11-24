//LOGINSCREEN FINISHED

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurbSydeApp.Forms
{
    public partial class LoginForm : Form
    {
        private String userName;
        public LoginForm()
        {
            InitializeComponent();
        }

        //usernameInput text must be at least 3 chars & stores name
        //passwordInput text must be at least 5 chars
        //Switches to the "OverviewForm"
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (this.usernameInput.Text.Trim() == "" || this.passwordInput.Text.Trim() == "" || this.usernameInput.Text.Trim().Length < 3 || this.passwordInput.Text.Trim().Length < 5)
            {
                MessageBox.Show("The username and/or input is invalid. Please re-enter and try again.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userName = this.usernameInput.Text.Trim();

                OverviewForm overviewScreen = new OverviewForm();
                overviewScreen.Dock = DockStyle.Fill;
                overviewScreen.TopLevel = false;
                MainForm.mainPanel.Controls.Clear();
                MainForm.mainPanel.Controls.Add(overviewScreen);
                overviewScreen.Show();

                this.Close();
            }
        }

        public String getUserName()
        {
            return userName;
        }
    }
}
