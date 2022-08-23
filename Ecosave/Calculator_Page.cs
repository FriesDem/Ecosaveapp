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
        private readonly ECOSAVEEntities _db;
        private readonly ECOSAVEEntities ecosaveDB;
        private readonly Calculator calculator;
        private readonly Billing_Table billing;
        private readonly Devices_Table devices;
        private User _user;
        public Calculator_Page(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            ecosaveDB = new ECOSAVEEntities();
            calculator = new Calculator();
            billing = new Billing_Table();
            devices = new Devices_Table();
            _user = user;
        }
        double dailyCost = 0, weeklyCost = 0, monthlyCost = 0, yearlyCost = 0;
        double fuelCost = 7.32, IPPCharge = 13.22, GCT = 0.15, finalCharge = 0, kwh = 0, hours;
        string device;

       

       

        private void Calculator_Page_Load(object sender, EventArgs e)
        {
            var devices = ecosaveDB.Devices_Tables.ToList();
            cmboDeviceSelect.DataSource = devices;
            cmboDeviceSelect.ValueMember = "ID";
            cmboDeviceSelect.DisplayMember = "Type_Of_Device";

        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                      

        private void clearBtn_Click(object sender, EventArgs e)
        {
            finalCharge = 0;
            lblDailyCostDisplay.Text = "";
            lblWeeklyCostDisplay.Text = "";
            lblMonthlyCostDisplay.Text = ""; 
            lblYearlyCostDisplay.Text = "";
            txtHoursUsed.Text = "";
            txtPowerOutput.Text = "";
            

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
            
                hours = Convert.ToDouble(txtHoursUsed.Text);
                kwh = Convert.ToDouble(txtPowerOutput.Text);
                finalCharge = ((fuelCost * kwh * hours) + (IPPCharge * kwh * hours));
                finalCharge = finalCharge / 1000;
                dailyCost = finalCharge;
                weeklyCost = finalCharge * 7;
                monthlyCost = finalCharge * 30;
                yearlyCost = finalCharge * 365;
                device = cmboDeviceSelect.Text;

                lblDailyCostDisplay.Text = "$ " + dailyCost.ToString("N2") + " JMD";
                lblWeeklyCostDisplay.Text = "$ " + weeklyCost.ToString("N2") + " JMD";
                lblMonthlyCostDisplay.Text = "$ " + monthlyCost.ToString("N2") + " JMD";
                lblYearlyCostDisplay.Text = "$ " + yearlyCost.ToString("N2") + " JMD";
               
                calculator.Device = device;
                calculator.Power_Average = double.Parse(txtPowerOutput.Text);
                calculator.Hours_Used = int.Parse(txtHoursUsed.Text);
                calculator.Daily_Average = Convert.ToInt64(dailyCost);
                calculator.Weekly_Average = Convert.ToInt64(weeklyCost);
                calculator.Monthly_Average = Convert.ToInt64(monthlyCost);
                ecosaveDB.Calculators.Add(calculator);
               
                ecosaveDB.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
               
        }
    }
}
