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
    public partial class CAAForm : Form
    {
        private readonly ECOSAVEEntities _db;
        public CAAForm()
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

    

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                var tpassword = tbpassword.Text;
                var confirmpassword = tbconfirmpassword.Text;
                var email1 = tbemail.Text;
                if (!email1.Contains("@"))
                {
                    MessageBox.Show("Email is missing @");
                    if (tpassword != confirmpassword)
                    {
                        MessageBox.Show("Password do not match.Please try again !!");
                    }
                }
                if (email1.Contains("@"))
                {
                    if (tpassword.Equals(confirmpassword))
                    {
                        var username = tbusername.Text;
                        var email = tbemail.Text;
                        var roleid = 2;
                        var password = Utils.Hashpassword(tbpassword.Text);
                        var tbconfirm = Utils.Hashpassword(tbconfirmpassword.Text);
                        var user = new User
                        {
                            Username = username,
                            Email = email,
                            Password = password,
                            isActive = true
                        };
                        _db.Users.Add(user);
                        _db.SaveChanges();

                        var userid = user.ID;

                        var userRole = new UserRole
                        {
                            roleid = roleid,
                            userid = userid
                        };

                        _db.UserRoles.Add(userRole);
                        _db.SaveChanges();

                        MessageBox.Show("New User Added Succesfully");

                        this.Close();
                        Creating_profile_1 create = new Creating_profile_1(user);
                        create.Show();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void reveal_Click_1(object sender, EventArgs e)
        {
            if (tbpassword.PasswordChar == '*')
            {
                tbpassword.PasswordChar = '\0';
            }
            else
            {
                tbpassword.PasswordChar = '*';
            }
        }

        private void reveal2_Click_1(object sender, EventArgs e)
        {
            if (tbconfirmpassword.PasswordChar == '*')
            {
                tbconfirmpassword.PasswordChar = '\0';
            }
            else
            {
                tbconfirmpassword.PasswordChar = '*';
            }
        }
    }
}
