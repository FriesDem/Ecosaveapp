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
    public partial class ProfilePage : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
            public ProfilePage()
        {
            InitializeComponent();
           
        }
        public ProfilePage(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
            }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("EditProfile"))
            {
                var EditProfile = new EditProfile(_user);
                EditProfile.MdiParent = this.MdiParent;
                EditProfile.Show();

            }
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            
            var user = _db.Person_Tables.FirstOrDefault(x => x.UserID == _user.ID);
            if (user == null)
            {
                MessageBox.Show("Invalid User");
                return;
            }
            if (user != null)
            {
                var first = user.First_Name.Trim();
                var last = user.Last_Name.Trim();
                name.Text = first + last;
                DeviceCount.Text = user.Number_of_Devices.ToString();
                NumberRooms.Text = user.Number_of_Houses.ToString();
            }
        }

        private void DeviceData_Click(object sender, EventArgs e)
        {
            
            if (!Utils.FormIsOpen("DeviceData"))
            {
                var DeviceData = new DeviceData();
                DeviceData.MdiParent = this.MdiParent;
                DeviceData.Show();

            }
        }

        private void Roomsdata_Click(object sender, EventArgs e)
        {
           
            if (!Utils.FormIsOpen("RoomsData"))
            {
                var RoomsData = new RoomsData();
                RoomsData.MdiParent = this.MdiParent;
                RoomsData.Show();

            }
        }
    }
}

