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
        private Car[] carArray;                                                 //Stores the cars in the car queue
        private int[] carsOnScreen;
        //private Queue<Car> carQueue;
        //Constructor
        public DispenseForm()
        {
            InitializeComponent();
            carArray = MainForm.mainScreen.createCarArray("C:\\Users\\JAISE\\source\\repos\\CurbSydeApp\\carNames.txt");
            carsOnScreen = new int[5];
            //carQueue = new Queue<Car>();
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
            SelectedCarForm.selectScreen.updateScreen(carArray[carsOnScreen[0]]);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton2_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[carsOnScreen[1]]);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton3_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[carsOnScreen[2]]);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton4_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[carsOnScreen[3]]);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        //Switch to "SelectedCarForm"
        private void carButton5_Click(object sender, EventArgs e)
        {
            SelectedCarForm.selectScreen.updateScreen(carArray[carsOnScreen[4]]);

            SelectedCarForm.selectScreen.Dock = DockStyle.Fill;
            SelectedCarForm.selectScreen.TopLevel = false;
            MainForm.mainPanel.Controls.Clear();
            MainForm.mainPanel.Controls.Add(SelectedCarForm.selectScreen);
            SelectedCarForm.selectScreen.Show();
        }
        #endregion

        //Modify timeLabel "00:00" = changes to time & calls to setLabels()
        public void updateScreen()
        {
            timeLabel.Text = MainForm.mainScreen.formatClock();

            //updateCars();

            int index = 0;

            for (int i = 0; i < carArray.Length; i++)
            {
                if(index <= 4)
                {
                    break;
                }

                if (carArray[i].time > 0)
                {
                    carsOnScreen[index] = i+1;
                }
            }

            setLabels();
        }
        //Modify the buttons & labels to correctly display the spot, name, and time with each car
        //                      if there aren't enough cars in queue for the buttons, hide the unused buttons
        private void setLabels()
        {
            if (carsOnScreen[0] != 0)
            {
                minLabel1.Visible = true;
                carButton1.Text = carArray[carsOnScreen[0]].spot + " - " + carArray[carsOnScreen[0]].name;
                if (carArray[carsOnScreen[0]].time < 7)
                {
                    minLabel1.Text = "- min";
                }
                else
                {
                    minLabel1.Text = carArray[carsOnScreen[0]].time + " min";
                }
            }
            else
            {
                minLabel1.Visible = false;
            }

            if (carsOnScreen[1] != 0)
            {
                minLabel2.Visible = true;
                carButton2.Text = carArray[carsOnScreen[1]].spot + " - " + carArray[carsOnScreen[1]].name;
                if (carArray[carsOnScreen[1]].time < 7)
                {
                    minLabel2.Text = "- min";
                }
                else
                {
                    minLabel2.Text = carArray[carsOnScreen[1]].time + " min";
                }
            }
            else
            {
                minLabel2.Visible = false;
            }

            if (carsOnScreen[2] != 0)
            {
                minLabel3.Visible = true;
                carButton3.Text = carArray[carsOnScreen[2]].spot + " - " + carArray[carsOnScreen[2]].name;
                if (carArray[carsOnScreen[2]].time < 7)
                {
                    minLabel3.Text = "- min";
                }
                else
                {
                    minLabel3.Text = carArray[carsOnScreen[2]].time + " min";
                }
            }
            else
            {
                minLabel3.Visible = false;
            }

            if (carsOnScreen[3] != 0)
            {
                minLabel4.Visible = true;
                carButton4.Text = carArray[carsOnScreen[3]].spot + " - " + carArray[carsOnScreen[3]].name;
                if (carArray[carsOnScreen[3]].time < 7)
                {
                    minLabel4.Text = "- min";
                }
                else
                {
                    minLabel4.Text = carArray[carsOnScreen[3]].time + " min";
                }
            }
            else
            {
                minLabel4.Visible = false;
            }

            if (carsOnScreen[4] != 0)
            {
                minLabel5.Visible = true;
                carButton5.Text = carArray[carsOnScreen[4]].spot + " - " + carArray[carsOnScreen[4]].name;
                if (carArray[carsOnScreen[4]].time < 7)
                {
                    minLabel5.Text = "- min";
                }
                else
                {
                    minLabel5.Text = carArray[carsOnScreen[4]].time + " min";
                }
            }
            else
            {
                minLabel5.Visible = false;
            }
        }
        //Updates the car info from updateClock()
        public void updateCars(int change)
        {
            
        }
    }
}
