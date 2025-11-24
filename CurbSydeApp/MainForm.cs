using CurbSydeApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurbSydeApp
{
    public enum Activity { Picking, Dispensing, Inactive, Off };           //Enum to represent Employee activities
    ////Struct to store pick hour information
    //public struct PickHour
    //{
    //    public int total;              //Stores total amount for the hour (30-300)
    //    public int genAmt;             //Stores the General amount of items from total
    //    public int coolAmt;            //Stores the Cool amount of items from total
    //    public int frozenAmt;          //Stores the frozen amount of items from total
    //}
    ////Struct to store car information
    //public struct Car
    //{
    //    public string name;            //Stores the customer name
    //    public char spot;              //Stores the spot the customer is parked in (A-H or -)
    //    public int time;               //Stores the total amt of time since the car was created
    //    public int stageNum;           //Stores the location of the general items (0-9)
    //    public int coolerNum;          //Stores the location of the cold items (0-9)
    //    public int freezerNum;         //Stores the location of the frozen items (0-9)
    //    public int sToteAmt;           //Stores the amt of Stage totes (1-5)
    //    public int cToteAmt;           //Stores the amt of Cooler totes (1-5)
    //    public int fToteAmt;           //Stores the amt of Freezer totes (1-5)
    //}
    //Struct to store employee information
    public struct Employee
    {
        public string name;            //Stores the employee name
        public int startShift;         //Stores the starting shift hour
        public int endShift;           //Stores the ending shift hour
        public Activity status;        //Stores the activity of the employee
    }

    public partial class MainForm : Form
    {
        public static Panel mainPanel;                          //Stores panel1 & allows other screens to access it to load in their screens
        public static MainForm mainScreen = new MainForm();     //Allows other screens to access MainForm
        private int clock;                                      //Stores the internal clock (500-2000)
        private int lastDisCheck;                               //Stores the clock time when the clock was last checked via checkClock() for dispense queue
        private int lastCheck;                                  //Stores the clock time when the clock was last checked via checkClock() for employees & pick drops
        //public string[] carNames;           //Stores the given car names from an input file
        //public string[] empNames;           //Stores the given employee names from an input file
        private Random ranNum;                                  //Stores the random numbers generated for initializations

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            mainPanel = panel1;                 //Initializes
            clock = 500;                        //Initializes
            lastDisCheck = 500;                 //Initializes
            lastCheck = 500;                    //Initializes
            //carNames = new string[20];          //Initializes
            //empNames = new string[11];          //Initializes
            ranNum = new Random();              //Initializes
            //employeeArray = createEmpArray("C:\\Users\\JAISE\\source\\repos\\CurbSydeApp\\employeeNames.txt");   //Initializes
        }
        //Function that loads first screen via panel1
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm.loginScreen.Dock = DockStyle.Fill;
            LoginForm.loginScreen.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(LoginForm.loginScreen);
            LoginForm.loginScreen.Show();
        }
        //Adds minutes to the clock & converts every hour to 100s
        public void updateClock(int amt)
        {
            clock += amt;
            int tempClock = clock % 100;

            if (tempClock / 60 > 0)
            {
                clock -= 60 * (tempClock / 60);
                clock += 100 * (tempClock / 60);
            }
        }
        ////WIP
        //public int clockCheck()
        //{
        //    return 0;
        //}
        ////Creates a pickHourArray using ranNum
        //public PickHour[] createPickHourArray()
        //{
        //    PickHour[] temp = new PickHour[15];

        //    for(int i = 0; i < temp.Length; i++)
        //    {
        //        temp[i].total = ranNum.Next(301);
        //        temp[i].genAmt = ranNum.Next(temp[i].total+1);
        //        temp[i].coolAmt = ranNum.Next((temp[i].total-temp[i].genAmt)+1);
        //        temp[i].frozenAmt = temp[i].total - (temp[i].genAmt + temp[i].coolAmt);
        //    }

        //    return temp;
        //}

        //Creates an employeeArray using ranNum (last index = null for User)
        public Employee[] createEmpArray(string e)
        {
            Employee[] temp = new Employee[6];
            Console.WriteLine("MadeIt");

            string line = "";
            try
            {
                StreamReader emps = new StreamReader(e);

                for (int i = 0; i < temp.Length - 1; i++)
                {
                    line = emps.ReadLine();

                    temp[i].name = line.Substring(0, line.IndexOf('-'));

                    line = line.Substring(line.IndexOf("-") + 1);
                    temp[i].startShift = int.Parse(line.Substring(0, line.IndexOf('-')));

                    line = line.Substring(line.IndexOf('-') +1);
                    temp[i].endShift = int.Parse(line.Substring(0)) + 12;

                    temp[i].status = (Activity)ranNum.Next(3);
                }
                emps.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
            }

            temp[5].name = null;
            temp[5].startShift = 5;
            temp[5].endShift = 21;
            temp[5].status = Activity.Inactive;

            return temp;
        }
        ////Creates a carArray setting everything to 0, '-', or null
        //public Car[] createCarArray()
        //{
        //    Car[] temp = new Car[10];

        //    for (int i = 0; i < temp.Length - 1; i++)
        //    {
        //        temp[i].name = null;
        //        temp[i].spot = '-';
        //        temp[i].time = 0;
        //        temp[i].stageNum = 0;
        //        temp[i].coolerNum = 0;
        //        temp[i].freezerNum = 0;
        //        temp[i].sToteAmt = 0;
        //        temp[i].cToteAmt = 0;
        //        temp[i].fToteAmt = 0;
        //    }

        //    return temp;
        //}
        ////Updates the last index of the employeeArray to include the user's name
        //public void updateEmployeeArray(string name)
        //{
        //    employeeArray[5].name = name;
        //}

        //Getter function - returns clock value
        public int getClock()
        {
            return clock;
        }
        //Formats the clock for the screens' labels
        public string formatClock()
        {
            string result = "";

            if (clock / 100 < 10)
            {
                result += "0" + (clock / 100);
            } else if (clock/ 100 < 13)
            {
                result += "" + (clock / 100);
            }else
            {
                result += "0" + ((clock / 100) - 12);
            }

            result += ":";

            if(clock % 100 < 10)
            {
                result += "0" + (clock % 100);
            } else
            {
                result += "" + (clock % 100);
            }

            return result;
        }
    }
}
