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
    public partial class Paasword_Reset : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Paasword_Reset(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbpassword.Text;
                var confirmpassword = tbconfirmpassword.Text;

                if (password != confirmpassword)
                {
                    MessageBox.Show("Password do not match.Please try again !!");
                }
                if (password.Equals(confirmpassword))
                {

                    var user = _db.Users.FirstOrDefault(q => q.Email == _user.Email);
                    {
                        user.Password = Utils.Hashpassword(password);
                    };
                }






                _db.SaveChanges();
                MessageBox.Show("Password Was Reset Succesfully!");
                Close();


                LoginForm login = new LoginForm();
                login.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("An Error Has Occured.Please To Try Again!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbpassword.Text = "";
            tbconfirmpassword.Text = "";
        }
    }
}
