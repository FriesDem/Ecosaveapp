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
    public partial class Smarthubdevices : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Smarthubdevices(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }
      
        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void SolarGen1_Click(object sender, EventArgs e)
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

        private void SolarGen2_Click(object sender, EventArgs e)
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

        private void SolarGen3_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Efergy_Elite_Max_Display_Kit"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Efergy_Elite_Max_Display_Kit = new Efergy_Elite_Max_Display_Kit(_user);
                Efergy_Elite_Max_Display_Kit.MdiParent = this.MdiParent;
                Efergy_Elite_Max_Display_Kit.Show();

            }
        }
    }
}
