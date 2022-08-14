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
        double dailyCost = 0, weeklyCost = 0, monthlyCost = 0, yearlyCost = 0;
        double fuelCost = 7.32, IPPCharge = 13.22, GCT = 0.15, finalCharge = 0, kwh = 0;

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double numDevices = 0;
        

        private void clearBtn_Click(object sender, EventArgs e)
        {
            finalCharge = 0;
            lblDailyCostDisplay.Text = "";
            lblWeeklyCostDisplay.Text = "";
            lblMonthlyCostDisplay.Text = ""; 
            lblYearlyCostDisplay.Text = "";
            txtHoursUsed.Text = "";
            txtPowerOutput.Text = "";
            numberOfDevices.Value = 0;

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (numberOfDevices.Value == 0)
            {
                MessageBox.Show("Please Enter the number of devices you wish to calculate for");
            }
            else
            {
                numDevices = Convert.ToDouble(numberOfDevices.Value);
                kwh = Convert.ToDouble(txtPowerOutput.Text);
                finalCharge = ((fuelCost * kwh) + (IPPCharge * kwh)) / numDevices;
                dailyCost = finalCharge;
                weeklyCost = finalCharge * 7;
                monthlyCost = finalCharge * 30;
                yearlyCost = finalCharge * 365;
                
                lblDailyCostDisplay.Text = "$ " + dailyCost.ToString("N2") + " JMD";
                lblWeeklyCostDisplay.Text = "$ " + weeklyCost.ToString("N2") + " JMD";
                lblMonthlyCostDisplay.Text = "$ " + monthlyCost.ToString("N2") + " JMD";
                lblYearlyCostDisplay.Text = "$ " + yearlyCost.ToString("N2") + " JMD";


                calculator.Number_Of_Devices = Convert.ToInt32(numDevices);
                calculator.Power_Average = double.Parse(txtPowerOutput.Text);
                calculator.Hours_Used = int.Parse(txtHoursUsed.Text);
                calculator.Daily_Average = Convert.ToInt64(dailyCost);
                calculator.Weekly_Average = Convert.ToInt64(weeklyCost);
                calculator.Monthly_Average = Convert.ToInt64(monthlyCost);
                ecosaveDB.Calculators.Add(calculator);
                ecosaveDB.SaveChanges();

            }



        }
    }
}
