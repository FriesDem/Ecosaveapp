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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (!Utils.FormIsOpen("ProfilePage"))
            {
                var Profile = new ProfilePage();
                Profile.MdiParent = this;
                Profile.Show();

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            FNameTB.Visible = true;
            LNameTB.Visible = true;
            StreetTB.Visible = true;
            ParishTB.Visible = true;
            ZipcodeTB.Visible = true;
            OccupationTB.Visible = true;
            PhoneNumber.Visible = true;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {    
            FNameTB.Visible = false;
            LNameTB.Visible = false;
            StreetTB.Visible = false;
            ParishTB.Visible = false;
            ZipcodeTB.Visible = false;
            OccupationTB.Visible = false;
            PhoneNumber.Visible = false;

        }
    }
}
