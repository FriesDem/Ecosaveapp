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
    public partial class Home : Form
    {
        private LoginForm _login;
        public string _RoleName;
        public User _user;
        public Home()
        {
            InitializeComponent();
        }
        public Home(LoginForm login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _RoleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
        private void Home_Load(object sender, EventArgs e)
        {

            if (_user.Password == Utils.DefaultHashpassword())
            {
                var resetpassword = new Paasword_Reset(_user);
                resetpassword.ShowDialog();
            }
            var username = _user.Username;
            tsilogintext.Text = username;
            var newland = tsilogintext.Text;
            if (_RoleName != "admin")
            {
                manageUserToolStripMenuItem.Visible = false;

            }

            var Profile = new ProfilePage(_user);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                this.Close();
                LoginForm log = new LoginForm();
                log.Show();
            }
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ProfilePage"))
            {
                
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var newland = tsilogintext.Text;
                var Profile = new ProfilePage(_user);
                Profile.MdiParent = this;
                Profile.Show();

            }
        }
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("Calculator_Page"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Calculate = new Calculator_Page();
                Calculate.MdiParent = this;
                Calculate.Show();
            }
        }
        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                if (!Utils.FormIsOpen("Store_Page"))
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var Store_Page = new Store_Page();
                    Store_Page.MdiParent = this;
                    Store_Page.Show();
                }
        }
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                if (!Utils.FormIsOpen("About_Us"))
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var About_Us = new About_Us();
                    About_Us.MdiParent = this;
                    About_Us.Show();
                }
        }
        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("manageUsers"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var UserManagement = new manageUsers();
                UserManagement.MdiParent = this;
                UserManagement.Show();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("HomePage"))
            {
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var HomePage = new HomePage();
                    HomePage.MdiParent = this;
                    HomePage.Show();
                }
            }
        }
        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Calculator_Page"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Calculate = new Calculator_Page();
                Calculate.MdiParent = this;
                Calculate.Show();
            }
        }
        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ProfilePage"))
            {
                
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var newland = tsilogintext.Text;
                var Profile = new ProfilePage(_user); 
                Profile.MdiParent = this;
                Profile.Show();

            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Store_Page"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Store_Page = new Store_Page();
                Store_Page.MdiParent = this;
                Store_Page.Show();
            }
        }
        private void TipsBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Tips_Page"))
            {
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var Tips = new Tips_Page();
                    Tips.MdiParent = this;
                    Tips.Show();
                }
            }
        }

        private void billingTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Billing_Table_Screen"))
            {
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var Billing_Table = new Billing_Table_Screen();
                    Billing_Table.MdiParent = this;
                    Billing_Table.Show();
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("HomePage"))
            {
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var HomePage = new HomePage();
                    HomePage.MdiParent = this;
                    HomePage.Show();
                }
            }
        }

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Tips_Page"))
            {
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var Tips_Page = new Tips_Page();
                    Tips_Page.MdiParent = this;
                    Tips_Page.Show();
                }
            }
        }

        private void Aboutus_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("About_Us"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var About_Us = new About_Us();
                About_Us.MdiParent = this;
                About_Us.Show();
            }
        }
<<<<<<< HEAD
        }

        private void billingTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("BillingTable"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var BillingTable = new Billing_Table_Screen();
                BillingTable.MdiParent = this;
                BillingTable.Show();
            }
        }
    }
}
=======

        private void Storepage_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Store_Page"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Store_Page = new Store_Page();
                Store_Page.MdiParent = this;
                Store_Page.Show();
            }
        }

        private void Bills_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Billing_Table_Screen"))
            {
                {
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var Billing_Table = new Billing_Table_Screen();
                    Billing_Table.MdiParent = this;
                    Billing_Table.Show();
                }
            }
        }
    }
}
>>>>>>> 1da4c87f0dd7ea5093ed81e3e7e47c2d0d1c08c5
