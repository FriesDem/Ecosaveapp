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
    public partial class CalculatorInfo : Form
    {
        private Billing_Table billing;
        private ECOSAVEEntities ecosaveDB;

        double energyCharge = 0, energyUsed = 0, fuelCharge = 0, custCharge = 0, IPPCharge = 0, demandCharge = 0, finalCharge = 0;

        

        string readingType;
        public CalculatorInfo()
        {
            InitializeComponent();
            billing = new Billing_Table();
            ecosaveDB = new ECOSAVEEntities();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                energyCharge = Convert.ToDouble(txtEnergyCharge.Text);
                energyUsed = Convert.ToDouble(txtEnergyUsed.Text);
                fuelCharge = Convert.ToDouble(txtFuelCharge.Text);
                custCharge = Convert.ToDouble(txtCustomerCharge.Text);
                IPPCharge = Convert.ToDouble(txtIPPCharge.Text);
                demandCharge = Convert.ToDouble(txtDemandCharge.Text);
                if (txtReadingType.Text == "Actual" || txtReadingType.Text == "Estimated")
                {
                    readingType = txtReadingType.Text;

                    billing.Energy_Charge = energyCharge;
                    billing.Energy_Used = energyUsed;
                    billing.Fuel_Charge = fuelCharge;
                    billing.Customer_Charge = custCharge;
                    billing.IPP_Charge = IPPCharge;
                    billing.Reading_Type = readingType;

                    ecosaveDB.Billing_Tables.Add(billing);
                    ecosaveDB.SaveChanges();
                    MessageBox.Show("Data Saved Successfully");
                }
                else
                {
                    MessageBox.Show("The Reading Type needs to be either Actual or Estimated");


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong. Please Try Again");
            }
            

            
        }
    }
}
