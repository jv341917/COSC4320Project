using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurbSydeApp.Forms
{
    public partial class DispenseForm : Form
    {
        public static DispenseForm dispenseScreen = new DispenseForm();         //Allows other screens to access DispenseForm
        private List<Car> carArray;                                             //Stores the cars in the car queue
        private string[] carNames;                                              //Stores the car names
        private Random ranNum;

        //Constructor
        public DispenseForm()
        {
            InitializeComponent();
            carArray = new List<Car>();
            carNames = MainForm.mainScreen.readInFile("C:\\Users\\user\\source\\Repos\\CurbSydeApp\\carNames.txt");
            ranNum = new Random();
        }
        #region Screen Switches
        //Switches to "PickForm" & updates the clock in MainForm
        private void switchPickButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            PickForm.pickScreen.updateScreen();

            PickForm.pickScreen.Dock = DockStyle.Fill;
            PickForm.pickScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(PickForm.pickScreen);
            PickForm.pickScreen.Show();
        }
        //Switches to "OverviewForm" & updates the clock in MainForm
        private void switchOverviewButton_Click(object sender, EventArgs e)
        {
            MainForm.mainScreen.updateClock(1);
            OverviewForm.overviewScreen.updateScreen();

            OverviewForm.overviewScreen.Dock = DockStyle.Fill;
            OverviewForm.overviewScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(OverviewForm.overviewScreen);
            OverviewForm.overviewScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton1_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[0], 0);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton2_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[1], 1);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton3_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[2], 2);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton4_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[3], 3);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton5_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[4], 4);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        #endregion

        //Modify timeLabel "00:00" = changes to time & changes the 5 car labels
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();

            if (carArray.Count > 0)
            {
                carButton1.Visible = true;
                minLabel1.Visible = true;
                if (carArray[0].time < 7)
                {
                    carButton1.Text = "/ - " + carArray[0].name;
                    minLabel1.Text = "- min";
                }
                else
                {
                    carButton1.Text = carArray[0].spot + " - " + carArray[0].name;
                    minLabel1.Text = carArray[0].time + " min";
                }
            }
            else
            {
                carButton1.Visible = false;
                minLabel1.Visible = false;
            }

            if (carArray.Count > 1)
            {
                carButton2.Visible = true;
                minLabel2.Visible = true;
                if (carArray[1].time < 7)
                {
                    carButton2.Text = "/ - " + carArray[1].name;
                    minLabel2.Text = "- min";
                }
                else
                {
                    carButton2.Text = carArray[1].spot + " - " + carArray[1].name;
                    minLabel2.Text = carArray[1].time + " min";
                }
            }
            else
            {
                carButton2.Visible = false;
                minLabel2.Visible = false;
            }

            if (carArray.Count > 2)
            {
                carButton3.Visible = true;
                minLabel3.Visible = true;
                if (carArray[2].time < 7)
                {
                    carButton3.Text = "/ - " + carArray[2].name;
                    minLabel3.Text = "- min";
                }
                else
                {
                    carButton3.Text = carArray[2].spot + " - " + carArray[2].name;
                    minLabel3.Text = carArray[2].time + " min";
                }
            }
            else
            {
                carButton3.Visible = false;
                minLabel3.Visible = false;
            }

            if (carArray.Count > 3)
            {
                carButton4.Visible = true;
                minLabel4.Visible = true;
                if (carArray[3].time < 7)
                {
                    carButton4.Text = "/ - " + carArray[3].name;
                    minLabel4.Text = "- min";
                }
                else
                {
                    carButton4.Text = carArray[3].spot + " - " + carArray[3].name;
                    minLabel4.Text = carArray[3].time + " min";
                }
            }
            else
            {
                carButton4.Visible = false;
                minLabel4.Visible = false;
            }

            if (carArray.Count > 4)
            {
                carButton5.Visible = true;
                minLabel5.Visible = true;
                if (carArray[4].time < 7)
                {
                    carButton5.Text = "/ - " + carArray[4].name;
                    minLabel5.Text = "- min";
                }
                else
                {
                    carButton5.Text = carArray[4].spot + " - " + carArray[4].name;
                    minLabel5.Text = carArray[4].time + " min";
                }
            }
            else
            {
                carButton5.Visible = false;
                minLabel5.Visible = false;
            }
        }
        //Adds car to carArray
        public void addCar()
        {
            Car c = new Car();
            c.name = carNames[ranNum.Next(19)];

            char temp = (char)(ranNum.Next(7) + 65);
            for(int i = 0; i < carArray.Count; i++)
            {
                if(temp == carArray.ElementAt(i).spot)
                {
                    temp = (char)(ranNum.Next(7) + 65);
                }
            }
            c.spot = temp;
            c.time = 0;
            c.stageNum = ranNum.Next(9);
            c.coolerNum = ranNum.Next(9);
            c.freezerNum = ranNum.Next(9);
            c.sToteAmt = ranNum.Next(5) + 1;
            c.cToteAmt = ranNum.Next(5) + 1;
            c.fToteAmt = ranNum.Next(5) + 1;

            carArray.Add(c);
        }
        //Updates the car info from updateClock()
        public void updateCars(int change)
        {
            for (int i = 0; i < carArray.Count; i++)
            {
                Car c = carArray.ElementAt(i);
                c.time += change;
                carArray[i] = c;
            }
        }

        public Car getCar(int i)
        {
            return carArray.ElementAt(i);
        }

        public void removeCar(int i)
        {
            carArray.RemoveAt(i);
        }
    }
}
