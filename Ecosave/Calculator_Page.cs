using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecosave
{
    public partial class Calculator_Page : Form
    {
        private readonly ECOSAVEEntities ecosaveDB;
        private readonly Calculator calculator;

        public Calculator_Page()
        {
            InitializeComponent();
            ecosaveDB = new ECOSAVEEntities();
            calculator = new Calculator();
        }
        double result = 0.0;
        int equalBtnCount = 0;
        string function = "";
        bool functionPerformed = false;
        int numDevices;

        double finalAvg = 0.0;
        double tempVal;

        private void clearBtn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            tempValueLabel.Text = "";

            result = 0.0;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            equalBtnCount++;

            if (numDevices == 0)
            {
                MessageBox.Show("Please choose the number of devices you wish to find the average of first");
            }
            else if (numDevices > 0)
            {
                switch (function)
                {

                    case "+":
                        calculatorDisplay.Text = (tempVal + Double.Parse(calculatorDisplay.Text)).ToString();
                        result += double.Parse(calculatorDisplay.Text);
                        break;

                    case "-":
                        calculatorDisplay.Text = (tempVal - Double.Parse(calculatorDisplay.Text)).ToString();
                        result += double.Parse(calculatorDisplay.Text);
                        break;

                    case "/":
                        calculatorDisplay.Text = (tempVal / Double.Parse(calculatorDisplay.Text)).ToString();
                        result += double.Parse(calculatorDisplay.Text);
                        break;

                    case "x":
                        calculatorDisplay.Text = (tempVal * Double.Parse(calculatorDisplay.Text)).ToString();
                        result += double.Parse(calculatorDisplay.Text);
                        break;

                    default:
                        break;
                }
                if (equalBtnCount == numDevices)
                {
                    tempValueLabel.Text = "";
                    finalAvg = result / numDevices;

                    MessageBox.Show($" Your Power Average is {finalAvg}\n Click the submit button to submit your device averages");
                    calculatorDisplay.Visible = false;
                }
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            {
                if (calculatorDisplay.Text == "0" || functionPerformed == true)
                    calculatorDisplay.Clear();
                functionPerformed = false;

                Button button = (Button)sender;
                if (button.Text == ".")
                {
                    if (!calculatorDisplay.Text.Contains("."))
                        calculatorDisplay.Text += button.Text;
                }
                else
                    calculatorDisplay.Text += button.Text;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            calculator.Number_Of_Devices = numDevices;
            calculator.Power_Average = finalAvg;
            ecosaveDB.Calculators.Add(calculator);
            ecosaveDB.SaveChanges();
            MessageBox.Show($"The final average of your devices is {finalAvg.ToString("N1")}");
            calculatorDisplay.Visible = true;
            numDevices = 0;
            numberOfDevices.Text = "0";
        }

        private void numDevicesBtn_Click(object sender, EventArgs e)
        {
            numDevices = int.Parse(numberOfDevices.Text);

            MessageBox.Show("Now, Enter the kwh of the device * the number of hours used\nFormat: kwH * hours used\n");
            numberOfDevices.Visible = false;
            calculatorDisplay.Visible = true;
        }

        private void Calculator_Page_Load(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Choose the number of devices you will be finding the average for.\n Then, input the power rating times the number" +
                "of hours you use for each. \nThis will give you your average. \nE.g. 60 * 5 = 300 kwH.");
                calculatorDisplay.Visible = false;
            }

        }
        private void arithmeticBtn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            function = button.Text;
            functionPerformed = true;
            tempVal = Double.Parse(calculatorDisplay.Text);
            tempValueLabel.Text = tempVal.ToString() + " " + function;
        }
    }
}
