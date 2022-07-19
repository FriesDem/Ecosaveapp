﻿using CouncilGamingClub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecosave
{
    public partial class LoginForm : Form
    {
        private readonly ECOSAVEEntities _db;

        public LoginForm()
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Title2_Click(object sender, EventArgs e)
        {

        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
              
                var email = EmailTB1.Text.Trim();
                var password = PasswordTB2.Text.Trim();

                var hashed_password = Utils.Hashpassword(password);

                var user = _db.Users.FirstOrDefault(Queryable => Queryable.Email == email && Queryable.Password == hashed_password);
            if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
            else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleName = role.Role.shortname;
                    var home = new Home(this, roleName);
                    home.Show();
                    this.Hide();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong. Please Try Again");
            }
        }

        private void FPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password_Reset reset = new Password_Reset();
            reset.Show();
        }

        private void CAABtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CAAForm newacc = new CAAForm();
            newacc.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
this.Close();
        }
    }
    }

