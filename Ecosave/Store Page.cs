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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnview1_Click(object sender, EventArgs e)

        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=solar+backpack&sprefix=solar+backpa%2Caps%2C176&ref=nb_sb_ss_mission-aware-v1_1_12");
            Process.Start(sInfo);
        }

        private void btnview2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=cree+60w+bulbs&crid=3PDAKEB4K3XBY&sprefix=cree+60w+bulbs%2Caps%2C138&ref=nb_sb_noss_2");
            Process.Start(sInfo);
        
        }

        private void btnview3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.co.uk/s?k=energy+saving+kettle&i=kitchen&ref=nb_sb_noss");
            Process.Start(sInfo);
        }

        private void btnview4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=portable+solar+fridge&crid=29CWMKOSOO70I&sprefix=portable+solar+fridge%2Caps%2C148&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }

        private void btnview5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=solar+generator&crid=UP3AGFVA0Q3G&sprefix=solar+generator%2Caps%2C161&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }

        private void btnview6_Click(object sender, EventArgs e)
        {

        }

        private void btnview7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=smart+electric+outlet&crid=2WMMPBQKT7G5O&sprefix=smart+electric+outle%2Caps%2C154&ref=nb_sb_noss_2");
            Process.Start(sInfo);
        
        }

        private void btnview8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=smart+meters&crid=3REM71OZ2D8A1&sprefix=smart+meters%2Caps%2C164&ref=nb_sb_noss_1");
            Process.Start(sInfo);
        }

        private void btnview9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.amazon.com/s?k=tumble+dryer+balls&crid=399X1X617DRJZ&sprefix=tumble+dryer+balls%2Caps%2C163&ref=nb_sb_noss_1");
            Process.Start(sInfo);
       
        }
    }
}
