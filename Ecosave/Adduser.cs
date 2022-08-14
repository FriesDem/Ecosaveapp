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
    public partial class AddUser : Form
    {
        private readonly ECOSAVEEntities _db;
        private manageUsers _manageUsers;
        public AddUser(manageUsers manageUsers)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _manageUsers = manageUsers;
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbroles.DataSource = roles;
            cbroles.ValueMember = "id";
            cbroles.DisplayMember = "name";
        }

        
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                var username = tbusername.Text;
                var email = tbemail.Text;
                var roleid = (int)cbroles.SelectedValue;
                var password = Utils.DefaultHashpassword();
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
                _manageUsers.PopulateGrid();
                Creating_profile_1 create = new Creating_profile_1(user);
                create.MdiParent = this.MdiParent;
                create.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            tbusername.Text = "";
            tbemail.Text = "";
            cbroles.SelectedValue = 0;
        }
    }
}
