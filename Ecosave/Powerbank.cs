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
    public partial class Powerbank : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Powerbank(User user)
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
            if (!Utils.FormIsOpen("Tranmix_Solar_Charger"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Tranmix_Solar_Charger = new Tranmix_Solar_Charger(_user);
                Tranmix_Solar_Charger.MdiParent = this.MdiParent;
                Tranmix_Solar_Charger.Show();

            }
        }

        private void SolarGen2_Click(object sender, EventArgs e)
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

        private void SolarGen3_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Takki_83Wh_Portable_Power_Station"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Takki_83Wh_Portable_Power_Station = new Takki_83Wh_Portable_Power_Station(_user);
                Takki_83Wh_Portable_Power_Station.MdiParent = this.MdiParent;
                Takki_83Wh_Portable_Power_Station.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void SolarGen5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void SolarGen6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void pb2_Click(object sender, EventArgs e)
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

        private void pb3_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Takki_83Wh_Portable_Power_Station"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Takki_83Wh_Portable_Power_Station = new Takki_83Wh_Portable_Power_Station(_user);
                Takki_83Wh_Portable_Power_Station.MdiParent = this.MdiParent;
                Takki_83Wh_Portable_Power_Station.Show();

            }
        }

        private void cms8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void cms9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }

        private void Cms10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Products On The Way Stay Tuned");
        }
    }
}
