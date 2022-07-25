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
    public partial class ForgotPassword : Form
      
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public ForgotPassword()
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = new User();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            var email = tbemail.Text.Trim();
            var username = tbusername.Text.Trim();



            var user = _db.Users.FirstOrDefault(Queryable => Queryable.Email == email && Queryable.Username == username && Queryable.isActive == true);
            if (user == null)
            {
                MessageBox.Show("Please provide valid credentials");
            }
            else
            {
                this.Close();
                var resetpassword = new ForgotPassword2(user);
                resetpassword.ShowDialog();


            }
            
        }
    }
}
