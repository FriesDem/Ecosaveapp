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
        private readonly ECOSAVEEntities _db;
        private User _user;
        public EditProfile(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
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
            PhoneNumberTB.Visible = true;
        }

        private void EditProfile_Load(object sender, EventArgs e)
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
                var parish = user.Parish.Trim();
                var street = user.Street.Trim();
                var zipcode = user.ZIP_Code.Trim();
                var occupation = user.Occupation.Trim();
                var telephone = user.Telephone.Trim();
                fname.Text = first;
                lname.Text = last;
                parishlb.Text = parish;
                streetlb.Text = street;
                zipcodelb.Text = zipcode;
                occupationlb.Text = occupation;
                phonenumb.Text = telephone;
            }
            FNameTB.Visible = false;
            LNameTB.Visible = false;
            StreetTB.Visible = false;
            ParishTB.Visible = false;
            ZipcodeTB.Visible = false;
            OccupationTB.Visible = false;
            PhoneNumberTB.Visible = false;

        }

        private void EditProfileSubbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var firstname = FNameTB;
                var lastname = LNameTB;
                var parishlb = ParishTB;
                var streetlb = StreetTB;
                var zipcodelb = ZipcodeTB;
                var occupationlb = OccupationTB;
                var telephonelb = PhoneNumberTB;

                var person = _db.Person_Tables.FirstOrDefault(x => x.UserID == _user.ID);
                {
                    if(firstname.Text != "")
                    {
                        person.First_Name = firstname.Text;
                        _db.SaveChanges();
                    }
                   if(lastname.Text != "")
                    {
                        person.Last_Name = lastname.Text;
                        _db.SaveChanges();
                    }
                    if(parishlb.Text != "")
                    {
                        person.Parish = parishlb.Text;
                        _db.SaveChanges();
                    }
                    if(streetlb.Text != "")
                    {
                        person.Street = streetlb.Text;
                        _db.SaveChanges();
                    }
                    if(zipcodelb.Text != "")
                    {
                        person.ZIP_Code = zipcodelb.Text;
                        _db.SaveChanges();
                    }
                    if(occupationlb.Text != "")
                    {
                        person.Occupation = occupationlb.Text;
                        _db.SaveChanges();
                    }
                    if(telephonelb.Text != "")
                    {
                        person.Telephone = telephonelb.Text;
                        _db.SaveChanges();
                    }
                   
                };
                
                MessageBox.Show("Updated Succesfully");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }
        }
    }
}
