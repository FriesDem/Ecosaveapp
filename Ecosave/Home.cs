﻿using CouncilGamingClub;
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
           this.Hide();
           LoginForm log = new LoginForm();
           log.Show();
            
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
                var Calculate = new Calculator_Page(_user);
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
                var Store_Page = new Store_Page(_user);
                Store_Page.MdiParent = this;
                Store_Page.Show();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("HomePage"))
            {
                
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var HomePage = new HomePage();
                    HomePage.MdiParent = this;
                    HomePage.Show();
                
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("HomePage"))
            {
                
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    var HomePage = new HomePage();
                    HomePage.MdiParent = this;
                    HomePage.Show();
                
            }
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Calculator_Page"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Calculate = new Calculator_Page(_user);
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
                var Profile = new ProfilePage(_user);
                Profile.MdiParent = this;
                Profile.Show();

            }
        }

        private void Storepage_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Store_Page"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Store_Page = new Store_Page(_user);
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

       

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Tips_Page"))
            {
                 if (ActiveMdiChild != null)
                     ActiveMdiChild.Close();
                    var Tips_Page = new Tips_Page();
                    Tips_Page.MdiParent = this;
                    Tips_Page.Show();
                
            }
        }

        private void billingTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("CalculatorInfo"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var CalculatorInfo = new BillingPage(_user);
                CalculatorInfo.MdiParent = this;
                CalculatorInfo.Show();

            }
        }
    }
}
