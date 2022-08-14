using CouncilGamingClub;
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
    public partial class Lightbulb : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Lightbulb(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void LightBulbs1_Click(object sender, EventArgs e)
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

        private void LightBulbs2_Click(object sender, EventArgs e)
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

        private void bulb3_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Sylvania_13W_CFL_T2_Spiral_Light_Bulb"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Sylvania_13W_CFL_T2_Spiral_Light_Bulb = new Sylvania_13W_CFL_T2_Spiral_Light_Bulb(_user);
                Sylvania_13W_CFL_T2_Spiral_Light_Bulb.MdiParent = this.MdiParent;
                Sylvania_13W_CFL_T2_Spiral_Light_Bulb.Show();

            }
        }

        private void LightBulbs3_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Sylvania_13W_CFL_T2_Spiral_Light_Bulb"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Sylvania_13W_CFL_T2_Spiral_Light_Bulb = new Sylvania_13W_CFL_T2_Spiral_Light_Bulb(_user);
                Sylvania_13W_CFL_T2_Spiral_Light_Bulb.MdiParent = this.MdiParent;
                Sylvania_13W_CFL_T2_Spiral_Light_Bulb.Show();

            }
        }

        private void bulb4_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("SYLVANIA_ECO_LED_A19_Light_Bulb"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var SYLVANIA_ECO_LED_A19_Light_Bulb = new SYLVANIA_ECO_LED_A19_Light_Bulb(_user);
                SYLVANIA_ECO_LED_A19_Light_Bulb.MdiParent = this.MdiParent;
                SYLVANIA_ECO_LED_A19_Light_Bulb.Show();

            }
        }

        private void LightBulbs4_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("SYLVANIA_ECO_LED_A19_Light_Bulb"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var SYLVANIA_ECO_LED_A19_Light_Bulb = new SYLVANIA_ECO_LED_A19_Light_Bulb(_user);
                SYLVANIA_ECO_LED_A19_Light_Bulb.MdiParent = this.MdiParent;
                SYLVANIA_ECO_LED_A19_Light_Bulb.Show();

            }
        }

        private void cms6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void LightBulbs5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void cms7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void LightBulbs6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");

        }
    } 
}
