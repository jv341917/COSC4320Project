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
        public static LoginForm loginScreen = new LoginForm();      //Allows other screens to access LoginForm
        private String userName;                                    //Stores the user's input

        //Constructor
        public LoginForm()
        {
            InitializeComponent();
            userName = "";                                          //Initializes
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

                OverviewForm.overviewScreen.updateScreen();

                OverviewForm.overviewScreen.Dock = DockStyle.Fill;
                OverviewForm.overviewScreen.TopLevel = false;
                MainForm.mainPanel.Controls.Clear();
                MainForm.mainPanel.Controls.Add(OverviewForm.overviewScreen);
                OverviewForm.overviewScreen.Show();

                EmployeesForm.employeeScreen.setUser(userName);

                this.Close();                                                   //Screen is never accessed again throughout program
            }
        }
        //Getter function - returns username
        public String getUserName()
        {
            return userName;
        }
    }
}
 