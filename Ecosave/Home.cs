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
        public Home(LoginForm login,User user)
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
            if(_user.Password == Utils.DefaultHashpassword())
            {
                var resetpassword = new Paasword_Reset(_user);
                resetpassword.ShowDialog();
            }
            var username = _user.Username;
            tsilogintext.Text = $"Logged In As:{username}";
            var newland = tsilogintext.Text;
            if (_RoleName != "admin")
            {
                manageUserToolStripMenuItem.Visible = false;
                
            }
            var Profile = new ProfilePage(newland);

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
                var Profile = new ProfilePage(newland);
                Profile.MdiParent = this;
                Profile.Show();

            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("Calculator"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Calculator = new Calculator_Page();
                Calculator.MdiParent = this;
                Calculator.Show();
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
                var About_Us = new About_Us ();
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
            if (!Utils.FormIsOpen("About_Us"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var About_Us = new About_Us();
                About_Us.MdiParent = this;
                About_Us.Show();
            }
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Calculator"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Calculator = new CalculatorInfo();
                Calculator.MdiParent = this;
                Calculator.Show();
            }
        }
    private void ProfileBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ProfilePage"))
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var newland = tsilogintext.Text;
                var Profile = new ProfilePage(newland); ;
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
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Tips = new Tips_Page();
            Tips.MdiParent = this;
            Tips.Show();
        }
        }
       

        }
}
