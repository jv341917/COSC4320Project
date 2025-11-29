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
    public partial class EmployeesForm : Form
    {
        public static EmployeesForm employeeScreen = new EmployeesForm();       //Allows other screens to access EmployeesForm
        private Employee[] employeeArray;                                       //Stores the employees for the day
        private Random ranNum;                                                  //Stores the random numbers generated for initializations

        //Constructor
        public EmployeesForm()
        {
            InitializeComponent();                              //Change to your file path to the txt file
            employeeArray = MainForm.mainScreen.createEmpArray("C:\\Users\\user\\source\\Repos\\CurbSydeApp\\employeeNames.txt");  //Initializes
            ranNum = new Random();                                                                                                  //Initializes
        }
        //Switches to "OverviewForm" & updates clock in MainForm
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            OverviewForm.overviewScreen.updateScreen();

            OverviewForm.overviewScreen.Dock = DockStyle.Fill;
            OverviewForm.overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(OverviewForm.overviewScreen);
            OverviewForm.overviewScreen.Show();
        }
        
        //Modify timeLabel so "00:00" changes with each time change
        //Modify each label so "Name" = employee name, "Activity" = activity, & labels disappear if an employee isn't clocked in
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();
            int clock = MainForm.mainScreen.getClock();

            employeeLabel1.Text = employeeArray[0].name + " - " + employeeArray[0].status;
            if (employeeArray[0].status == Activity.Off || employeeArray[0].startShift > clock/100)
            {
                employeeLabel1.Visible = false;
            }else if (employeeArray[0].startShift <= clock / 100)
            {
                employeeLabel1.Visible = true;
            }

            employeeLabel2.Text = employeeArray[1].name + " - " + employeeArray[1].status;
            if (employeeArray[1].status == Activity.Off || employeeArray[1].startShift > clock / 100)
            {
                employeeLabel2.Visible = false;
            }
            else if (employeeArray[1].startShift <= clock / 100)
            {
                employeeLabel2.Visible = true;
            }

            employeeLabel3.Text = employeeArray[2].name + " - " + employeeArray[2].status;
            if (employeeArray[2].status == Activity.Off || employeeArray[2].startShift > clock / 100)
            {
                employeeLabel3.Visible = false;
            }
            else if (employeeArray[2].startShift <= clock / 100)
            {
                employeeLabel3.Visible = true;
            }

            employeeLabel4.Text = employeeArray[3].name + " - " + employeeArray[3].status;
            if (employeeArray[3].status == Activity.Off || employeeArray[3].startShift > clock / 100)
            {
                employeeLabel4.Visible = false;
            }
            else if (employeeArray[3].startShift <= clock / 100)
            {
                employeeLabel4.Visible = true;
            }

            employeeLabel5.Text = employeeArray[4].name + " - " + employeeArray[4].status;
            if (employeeArray[4].status == Activity.Off || employeeArray[4].startShift > clock / 100)
            {
                employeeLabel5.Visible = false;
            }
            else if (employeeArray[4].startShift <= clock / 100)
            {
                employeeLabel5.Visible = true;
            }

            employeeLabel6.Text = employeeArray[5].name + " - " + employeeArray[5].status;
            if (employeeArray[5].status == Activity.Off || employeeArray[5].startShift > clock / 100)
            {
                employeeLabel6.Visible = false;
            }
            else if (employeeArray[5].startShift <= clock / 100)
            {
                employeeLabel6.Visible = true;
            }
        }
        //Changes the statuses of every employee except the User
        public void changeStatuses()
        {
            int c = MainForm.mainScreen.getClock() / 100;
            if(c > 12)
            {
                c -= 12;
            }

            for (int i = 0; i < employeeArray.Length-1; i++)
            {
                if (employeeArray[i].endShift <= c)
                {
                    employeeArray[i].status = Activity.Off;
                } else
                {
                    employeeArray[i].status = (Activity)ranNum.Next(3);
                }
            }

            updateScreen();
        }
        //Getter function - returns employeeArray
        public Employee[] getEmployeeArray()
        {
            return employeeArray;
        }
        //Setter function - alters last index of employeeArray to the user's name
        public void setUser(string n)
        {
            employeeArray[5].name = n;
        }
    }
}
