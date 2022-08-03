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
    public partial class Billing_Table_Screen : Form
    {
        public readonly ECOSAVEEntities ecosaveDB;
        public readonly Billing_Table billing;
        public readonly Calculator calculator;
        public Billing_Table_Screen()
        {
            InitializeComponent();
            ecosaveDB = new ECOSAVEEntities();
            billing = new Billing_Table();
        }

        double fuelCharge = 0, IPPCharge = 0, exRate = 0, kWh = 0, custCharge = 0, energyCharge = 0, energyUsed = 0;

        string readingType = "";

        private void submitBtn_Click(object sender, EventArgs e)
        {
            fuelCharge = double.Parse(txtFuelCharge.Text);
            IPPCharge = double.Parse(txtIPPCharge.Text);
            exRate = double.Parse(txtExchangeRate.Text);
            kWh = double.Parse(calculator.Power_Average.ToString());
            energyUsed = double.Parse(txtEnergyUsed.Text);
            custCharge = double.Parse(txtCustomerCharge.Text);
            energyCharge = double.Parse(txtEnergyCharge.Text);
            readingType = cmboReadingType.Text;

            billing.Fuel_Charge = fuelCharge;
            billing.IPP_Charge = IPPCharge;
            billing.Exchange_Rate = exRate;
            billing.Customer_Charge = custCharge;
            billing.Energy_Charge = energyCharge; 
            billing.Reading_Type = readingType;
            billing.Energy_Used = energyUsed;
            
            
            double subtotal_1, subtotal_2;
            subtotal_1 = (energyCharge * kWh + (custCharge));
            subtotal_2 = (fuelCharge * kWh + (IPPCharge * kWh));
            double finalCharge = (subtotal_1 + subtotal_2);

            if (kWh > 150)
            {
                double tempFinalCharge = finalCharge * 0.15;
                finalCharge += tempFinalCharge; 
            }

            lblFinalCharge.Text = finalCharge.ToString();
            billing.Final_Charge = finalCharge;

            ecosaveDB.Billing_Tables.Add(billing);
            ecosaveDB.SaveChanges();
        }
        
    }
}
