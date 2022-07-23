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
    public partial class Creating_profile_page_2 : Form
    {
        public Creating_profile_page_2()
        {
            InitializeComponent();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void SUYASubBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Eco Save");
            this.Close();
            LoginForm log = new LoginForm();
            log.Show();
        }
    }
}
