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
                var firstname = FNameTB.Text;
                var lastname = LNameTB.Text;
                var parishlb = ParishTB.Text;
                var streetlb = StreetTB.Text;
                var zipcodelb = ZipcodeTB.Text;
                var occupationlb = OccupationTB.Text;
                var telephonelb = PhoneNumberTB.Text;

                var person = _db.Person_Tables.FirstOrDefault(x => x.UserID == _user.ID);
                {
                  
                    int myNumber;
                    bool test1 = true;
                    bool test2 = true;
                    bool test3 = true;
                    bool test4 = true;
                    bool test5 = true;
                    bool test6 = true;
                    bool test7 = true;
                    if (int.TryParse(firstname, out myNumber) == true)
                    {
                        test1 = false;
                    }
                    if (int.TryParse(lastname, out myNumber) == true)
                    {
                        test2 = false;
                    }
                    if (int.TryParse(parishlb, out myNumber) == true)
                    {
                        test3 = false;
                    }
                    if (int.TryParse(occupationlb, out myNumber) == true)
                    {
                        test4 = false;
                    }
                    if (string.IsNullOrEmpty(StreetTB.Text))
                    {
                        test5 = false;
                    }
                    if (string.IsNullOrEmpty(ZipcodeTB.Text))
                    {
                        test6 = false;
                    }

                    if (PhoneNumberTB.Text == "(   )    -")
                    {
                        test7 = false;
                    }

                    if (test1 == false)
                    {
                        MessageBox.Show("Check To Ensure Name Is Letters");
                    }
                    if (test2 == false)
                    {
                        MessageBox.Show("Check To Ensure Name Is Letters");
                    }
                    if (test3 == false)
                    {
                        MessageBox.Show("Check To Ensure Parish Is Letters");
                    }
                    if (test4 == false)
                    {
                        MessageBox.Show("Check To Ensure Occupation Is Letters");
                    }

                    if (firstname != "" && test1 == true)
                    {
                        person.First_Name = firstname;
                        _db.SaveChanges();
                    }
                    if (lastname != "" && test2 == true)
                    {
                        person.Last_Name = lastname;
                        _db.SaveChanges();
                    }
                    if (parishlb != "" && test3 == true)
                    {
                        person.Parish = parishlb;
                        _db.SaveChanges();
                    }
                    if (streetlb != "" && test5 == true)
                    {
                        person.Street = streetlb;
                        _db.SaveChanges();
                    }
                    if (zipcodelb != "" && test6 == true)
                    {
                        person.ZIP_Code = zipcodelb;
                        _db.SaveChanges();
                    }
                    if (occupationlb != "" && test4 == true)
                    {
                        person.Occupation = occupationlb;
                        _db.SaveChanges();
                    }
                    if (telephonelb != "(   )    -" && test7 == true)
                    {
                        person.Telephone = telephonelb;
                        _db.SaveChanges();
                    }

                    MessageBox.Show("Updated Succesfully");
                    Close();
                };
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }
        }
    }
}
