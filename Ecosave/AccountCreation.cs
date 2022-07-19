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
    public partial class CAAForm : Form
    {
        public CAAForm()
        {
            InitializeComponent();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
