using CouncilGamingClub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecosave
{
    public partial class Store_Page : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Store_Page(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lightbulbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Lightbulb"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Lightbulb = new Lightbulb(_user);
                Lightbulb.MdiParent = this.MdiParent;
                Lightbulb.Show();

            }
        }

        private void solarGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Solargenerator"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Solargenerator = new Solargenerator(_user);
                Solargenerator.MdiParent = this.MdiParent;
                Solargenerator.Show();

            }
        }

        private void powerBankToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("Powerbank"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Powerbank = new Powerbank(_user);
                Powerbank.MdiParent = this.MdiParent;
                Powerbank.Show();

            }
        }

        private void smartHubDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("Smarthubdevices"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Smarthubdevices = new Smarthubdevices(_user);
                Smarthubdevices.MdiParent = this.MdiParent;
                Smarthubdevices.Show();

            }
        }

        private void LightBulbs_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Lightbulb"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Lightbulb = new Lightbulb(_user);
                Lightbulb.MdiParent = this.MdiParent;
                Lightbulb.Show();

            }
        }

        private void SolarGenerators_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Solargenerator"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Solargenerator = new Solargenerator(_user);
                Solargenerator.MdiParent = this.MdiParent;
                Solargenerator.Show();

            }
        }

        private void PowerBanks_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Powerbank"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Powerbank = new Powerbank(_user);
                Powerbank.MdiParent = this.MdiParent;
                Powerbank.Show();

            }
        }

        private void SmartHubDevices_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Smarthubdevices"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Smarthubdevices = new Smarthubdevices(_user);
                Smarthubdevices.MdiParent = this.MdiParent;
                Smarthubdevices.Show();

            }
        }

        private void bulb1_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Bioluz_LED_Light_Bulbs"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Bioluz_LED_Light_Bulbs = new Bioluz_LED_Light_Bulbs(_user);
                Bioluz_LED_Light_Bulbs.MdiParent = this.MdiParent;
                Bioluz_LED_Light_Bulbs.Show();

            }
        }

        private void bulb2_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Ecosmart_8_Pack_LED_Light_bulb"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Ecosmart_8_Pack_LED_Light_bulb = new Ecosmart_8_Pack_LED_Light_bulb(_user);
                Ecosmart_8_Pack_LED_Light_bulb.MdiParent = this.MdiParent;
                Ecosmart_8_Pack_LED_Light_bulb.Show();

            }
        }

        

        private void Store_Page_Load(object sender, EventArgs e)
        {
          
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Checkout"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Checkout = new Checkout(_user);
                Checkout.MdiParent = this.MdiParent;
                Checkout.Show();

            }
        }

        private void solargen1_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("EF_ECOFLOW_Solar_Generator_Delta_Max"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var EF_ECOFLOW_Solar_Generator_Delta_Max = new EF_ECOFLOW_Solar_Generator_Delta_Max(_user);
                EF_ECOFLOW_Solar_Generator_Delta_Max.MdiParent = this.MdiParent;
                EF_ECOFLOW_Solar_Generator_Delta_Max.Show();

            }
        }

        private void solargen2_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("EF_ECOFLOW_Solar_Generator_RIVER_Pro"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var EF_ECOFLOW_Solar_Generator_RIVER_Pro = new EF_ECOFLOW_Solar_Generator_RIVER_Pro(_user);
                EF_ECOFLOW_Solar_Generator_RIVER_Pro.MdiParent = this.MdiParent;
                EF_ECOFLOW_Solar_Generator_RIVER_Pro.Show();

            }
        }

        private void solargen3_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("BLUETTI_Solar_Generator"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var BLUETTI_Solar_Generator = new BLUETTI_Solar_Generator(_user);
                BLUETTI_Solar_Generator.MdiParent = this.MdiParent;
                BLUETTI_Solar_Generator.Show();

            }
        }

        private void powerbank1_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Durecopow_Solar_Charger"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Durecopow_Solar_Charger = new Durecopow_Solar_Charger(_user);
                Durecopow_Solar_Charger.MdiParent = this.MdiParent;
                Durecopow_Solar_Charger.Show();

            }
        }

        private void powerbank2_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Tranmix_Solar_Charger"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Tranmix_Solar_Charger = new Tranmix_Solar_Charger(_user);
                Tranmix_Solar_Charger.MdiParent = this.MdiParent;
                Tranmix_Solar_Charger.Show();

            }
        }

        private void smarthub1_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Emporia_Smart_Home_Energy_Monitor"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Emporia_Smart_Home_Energy_Monitor = new Emporia_Smart_Home_Energy_Monitor(_user);
                Emporia_Smart_Home_Energy_Monitor.MdiParent = this.MdiParent;
                Emporia_Smart_Home_Energy_Monitor.Show();

            }
        }

        private void smarthub2_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Sense_Energy_Monitor_with_Solar"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Sense_Energy_Monitor_with_Solar = new Sense_Energy_Monitor_with_Solar(_user);
                Sense_Energy_Monitor_with_Solar.MdiParent = this.MdiParent;
                Sense_Energy_Monitor_with_Solar.Show();

            }
        }
}
}
