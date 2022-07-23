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


        String _realname;

        public ProfilePage()
        {
            InitializeComponent();
          
        }
        public ProfilePage(String newland)
        {
            InitializeComponent();
       _realname = newland;
            
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
                var EditProfile = new EditProfile();
                EditProfile.MdiParent = this.MdiParent;
                EditProfile.Show();

            }
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            var newland = _realname;  
            lbname.Text = newland;
        }
    }
}

