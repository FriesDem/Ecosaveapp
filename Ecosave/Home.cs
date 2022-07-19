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
        public Home()
        {
            InitializeComponent();
        }
        public Home(LoginForm login, string roleShortName)
        {
            InitializeComponent();
            _login = login;
            _RoleName = roleShortName;
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
        private void Home_Load(object sender, EventArgs e)
        {

            if (_RoleName != "admin")
            {
                manageUserToolStripMenuItem.Visible = false;
                
            }
            
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
                var Profile = new ProfilePage();
                Profile.MdiParent = this;
                Profile.Show();

            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("Calculator"))
            {
                var Calculator = new Calculator();
                Calculator.MdiParent = this;
                Calculator.Show();
            }
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("manageUsers"))
            {
                var Store_Page = new Store_Page();
                Store_Page.MdiParent = this;
                Store_Page.Show();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("manageUsers"))
            {
                var About_Us = new About_Us ();
                About_Us.MdiParent = this;
                About_Us.Show();
            }
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("manageUsers"))
            {
                var UserManagement = new manageUsers();
                UserManagement.MdiParent = this;
                UserManagement.Show();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("manageUsers"))
            {
                var About_Us = new About_Us();
                About_Us.MdiParent = this;
                About_Us.Show();
            }
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Calculator"))
            {
                var Calculator = new Calculator();
                Calculator.MdiParent = this;
                Calculator.Show();
            }
        }
    private void ProfileBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ProfilePage"))
            {
                var Profile = new ProfilePage();
                Profile.MdiParent = this;
                Profile.Show();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Store_Page"))
            {
                var Store_Page = new Store_Page();
                Store_Page.MdiParent = this;
                Store_Page.Show();
            }
        }

        private void TipsBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Tips_Page"))
            { 
            var Tips = new Tips_Page();
            Tips.MdiParent = this;
            Tips.Show();
        }
        }
    }
}
