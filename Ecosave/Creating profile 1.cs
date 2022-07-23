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
    public partial class Creating_profile_1 : Form
    {
        public Creating_profile_1()
        {
            InitializeComponent();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Caa= new CAAForm();
            Caa.Show();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {this.Close();
            var createprofile = new Creating_profile_page_2();
            createprofile.Show();
        }
    }
}
