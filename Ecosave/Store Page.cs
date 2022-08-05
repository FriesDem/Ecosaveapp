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
        public Store_Page()
        {
            InitializeComponent();
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
                var Lightbulb = new Lightbulb();
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
                var Solargenerator = new Solargenerator();
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
                var Powerbank = new Powerbank();
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
                var Smarthubdevices = new Smarthubdevices();
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
                var Lightbulb = new Lightbulb();
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
                var Solargenerator = new Solargenerator();
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
                var Powerbank = new Powerbank();
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
                var Smarthubdevices = new Smarthubdevices();
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
                var Bioluz_LED_Light_Bulbs = new Bioluz_LED_Light_Bulbs();
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
                var Ecosmart_8_Pack_LED_Light_bulb = new Ecosmart_8_Pack_LED_Light_bulb();
                Ecosmart_8_Pack_LED_Light_bulb.MdiParent = this.MdiParent;
                Ecosmart_8_Pack_LED_Light_bulb.Show();

            }
        }
    }
}
