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
    }
}
