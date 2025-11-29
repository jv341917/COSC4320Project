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
    //Struct to store pick hour information
    public struct PickHour
    {
        public int total;              //Stores total amount for the hour (30-300)
        public int hour;
        public int genAmt;             //Stores the General amount of items from total
        public int coolAmt;            //Stores the Cool amount of items from total
        public int frozenAmt;          //Stores the frozen amount of items from total
    }
    //Struct to store car information
    public struct Car
    {
        public string name;            //Stores the customer name
        public char spot;              //Stores the spot the customer is parked in (A-H or -)
        public int time;               //Stores the total amt of time since the car was created
        public int stageNum;           //Stores the location of the general items (0-9)
        public int coolerNum;          //Stores the location of the cold items (0-9)
        public int freezerNum;         //Stores the location of the frozen items (0-9)
        public int sToteAmt;           //Stores the amt of Stage totes (1-5)
        public int cToteAmt;           //Stores the amt of Cooler totes (1-5)
        public int fToteAmt;           //Stores the amt of Freezer totes (1-5)
    }
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
        public static MainForm mainScreen;                      //Allows other screens to access MainForm
        public PickHour[] pickHours;                            //Stores the pick hour information
        private int clock;                                      //Stores the internal clock (500-2000)
        private int lastDisCheck;                               //Stores the clock time when the clock was last checked via checkClock() for dispense queue
        private int lastEmpCheck;                               //Stores the clock time when the clock was last checked via checkClock() for employee change
        private int lastCheck;                                  //Stores the clock time when the clock was last checked via checkClock() for pick drops
        private Random ranNum;                                  //Stores the random numbers generated for initializations

        //Constructor
        public MainForm()
        {
            mainScreen = this;
            InitializeComponent();
            mainPanel = panel1;                                 //Initializes
            //PickForm.pickScreen = new PickForm();               //Initializes - reduces premature intialization
            //PickWalkForm.pickWalkScreen = new PickWalkForm();   //Initializes - reduces premature intialization
            clock = 1330;                                        //Initializes
            lastDisCheck = 300;                                 //Initializes
            lastEmpCheck = 300;                                 //Initializes
            lastCheck = 500;                                    //Initializes
            ranNum = new Random();                              //Initializes
            pickHours = readPickHourFile("C:\\Users\\user\\Desktop\\MVS Coding\\CurbSydeApp\\pickHourInfo.txt");
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
        //      sends change amt to dispenseForm for the cars in queue & clockCheck()
        public void updateClock(int amt)
        {
            clock += amt;
            int tempClock = clock % 100;

            if (tempClock / 60 > 0)
            {
                clock -= 60 * (tempClock / 60);
                clock += 100 * (tempClock / 60);
            }

            DispenseForm.dispenseScreen.updateCars(amt);
            clockCheck();
        }
        //WIP
        //Checks the clock with last checked values to determine what to do
        public void clockCheck()
        {
            int c = ((clock / 100) * 60) + (clock % 100);

            //checks dispense & adds one car into queue no matter how much time has passed
            if(c - lastDisCheck > 7)
            {
                DispenseForm.dispenseScreen.addCar();

                lastDisCheck += (c - lastDisCheck);
            }
            //checks employees & changes statuses no matter how much time has passed
            if(c - lastEmpCheck >= 30)
            {
                EmployeesForm.employeeScreen.changeStatuses();

                lastEmpCheck += ((c-lastEmpCheck) / 30) * 30;
            }
            //checks picks & adds picks into the system
            if (clock - lastCheck >= 100)
            {
                //Pick drop

                lastCheck += 100;
            }
        }

        //Creates a pickHourArray using ranNum
        //public PickHour[] createPickHourArray()
        //{
        //    PickHour[] temp = new PickHour[15];

        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        temp[i] = new PickHour(); // <-- Must initialize each element

        //        temp[i].total = ranNum.Next(301);
        //        temp[i].genAmt = ranNum.Next(temp[i].total + 1);
        //        temp[i].coolAmt = ranNum.Next((temp[i].total - temp[i].genAmt) + 1);
        //        temp[i].frozenAmt = temp[i].total - (temp[i].genAmt + temp[i].coolAmt);
        //    }

        //    return temp;
        //}

        // Reads pickHourInfo 
        public PickHour[] readPickHourFile(string path)
        {
            List<PickHour> list = new List<PickHour>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('-');
                        if (parts.Length != 5) continue; // skip malformed lines

                        PickHour p = new PickHour
                        {
                            hour = int.Parse(parts[0]),
                            total = int.Parse(parts[1]),
                            genAmt = int.Parse(parts[2]),
                            coolAmt = int.Parse(parts[3]),
                            frozenAmt = int.Parse(parts[4])
                        };
                        list.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("PickHour read error: " + ex.Message);
            }

            return list.ToArray();
        }


        //Creates a car name array
        public string[] readInFile(string n)
        {
            string[] names = new string[20];

            string line = "";
            try
            {
                StreamReader na = new StreamReader(n);

                for(int i = 0; i < names.Length; i++)
                {
                    line = na.ReadLine();

                    names[i] = line;
                }
                na.Close();
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
            }

            return names;
        }
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
