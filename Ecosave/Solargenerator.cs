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
    public partial class Solargenerator : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Solargenerator(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }
       
        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolarGen1_Click(object sender, EventArgs e)
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

        private void SolarGen2_Click(object sender, EventArgs e)
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

        private void SolarGen3_Click(object sender, EventArgs e)
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

        private void SolarGen4_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Jackery_Solar_Generator_1500"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Jackery_Solar_Generator_1500 = new Jackery_Solar_Generator_1500(_user);
                Jackery_Solar_Generator_1500.MdiParent = this.MdiParent;
                Jackery_Solar_Generator_1500.Show();

            }
        }

        private void SolarGen5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void SolarGen6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void sg1_Click(object sender, EventArgs e)
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

        private void sg2_Click(object sender, EventArgs e)
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

        private void sg3_Click(object sender, EventArgs e)
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

        private void sg4_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Jackery_Solar_Generator_1500"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Jackery_Solar_Generator_1500 = new Jackery_Solar_Generator_1500(_user);
                Jackery_Solar_Generator_1500.MdiParent = this.MdiParent;
                Jackery_Solar_Generator_1500.Show();

            }
        }

        private void cms4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void cms5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }
    }
}
