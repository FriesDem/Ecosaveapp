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
    public partial class ForgotPassword2 : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public ForgotPassword2(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }   

        private void BacklogoBtn_Click_1(object sender, EventArgs e)
        {
            Close();

            {
                ForgotPassword fpass = new ForgotPassword();
                fpass.Show();
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            try
            {
                var password = tbpassword.Text;
                var confirmpassword = tbconfirmpassword.Text;
                if (password != confirmpassword)
                {
                    MessageBox.Show("Password do not match.Please try again !!");
                }
                
                 var user = _db.Users.FirstOrDefault(q => q.Email == _user.Email);
                

                
                    
                    _user.Password = Utils.Hashpassword(password);
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
            Close();

            {
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
