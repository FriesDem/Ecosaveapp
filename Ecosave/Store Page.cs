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

  

        private void backpack_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=solar+backpack&sprefix=solar+backpa%2Caps%2C176&ref=nb_sb_ss_mission-aware-v1_1_12");
            Process.Start(sInfo);
        }

        private void lightbulb_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=cree+60w+bulbs&crid=3PDAKEB4K3XBY&sprefix=cree+60w+bulbs%2Caps%2C138&ref=nb_sb_noss_2");
            Process.Start(sInfo);
        }

        private void kettle_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.co.uk/s?k=energy+saving+kettle&i=kitchen&ref=nb_sb_noss");
            Process.Start(sInfo);
        }

        private void Fridge_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=portable+solar+fridge&crid=29CWMKOSOO70I&sprefix=portable+solar+fridge%2Caps%2C148&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }

        private void Generator_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=solar+generator&crid=UP3AGFVA0Q3G&sprefix=solar+generator%2Caps%2C161&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }

        private void powerbank_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=solar+power+bank&crid=C78G9Q93HQEM&sprefix=solar+power+bank%2Caps%2C162&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }

        private void Smartplugs_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=smart+electric+outlet&crid=2WMMPBQKT7G5O&sprefix=smart+electric+outle%2Caps%2C154&ref=nb_sb_noss_2");
            Process.Start(sInfo);
        }

        private void Smartmeters_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=smart+meters&crid=3REM71OZ2D8A1&sprefix=smart+meters%2Caps%2C164&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }

        private void tumbleballs_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=tumble+dryer+balls&crid=399X1X617DRJZ&sprefix=tumble+dryer+balls%2Caps%2C163&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }
    }
}
