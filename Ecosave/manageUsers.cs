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
    public partial class manageUsers : Form
    {
        private readonly ECOSAVEEntities _db;
        public manageUsers()
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var adduser = new AddUser(this);
                adduser.MdiParent = this.MdiParent;
                adduser.Show();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)manageuser.SelectedRows[0].Cells["id"].Value;

                //query Database 
                var user = _db.Users.FirstOrDefault(Queryable => Queryable.ID == ID);
                var hashed_password = Utils.DefaultHashpassword();
                user.Password = hashed_password;
                _db.SaveChanges();

                MessageBox.Show($"{user.Username}'s Password has been reset!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroor:{ ex.Message}");
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)manageuser.SelectedRows[0].Cells["id"].Value;

                //query Database 
                var user = _db.Users.FirstOrDefault(Queryable => Queryable.ID == ID);

                user.isActive = user.isActive == true ? false : true;
                _db.SaveChanges();

                MessageBox.Show($"{user.Username}'s Active Status Has Changed!!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroor:{ ex.Message}");
            }
        }

        private void manageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        public void PopulateGrid()
        {
            var Eco = _db.Users
            .Select(q => new
            {
                q.ID,
                q.Username,
                q.Email,
                q.UserRoles.FirstOrDefault().Role.name,
                q.isActive
            })
            .ToList();
            manageuser.DataSource = Eco;
            manageuser.Columns["Username"].HeaderText = "Username";
            manageuser.Columns["Email"].HeaderText = "Email";
            manageuser.Columns["name"].HeaderText = "Name";
            manageuser.Columns["isActive"].HeaderText = "Active";


            manageuser.Columns["ID"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
