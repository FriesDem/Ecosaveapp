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
    public partial class Creating_profile_1 : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Creating_profile_1(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
            
        }
        
        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Caa= new CAAForm();
            Caa.Show();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var user = _db.Users.FirstOrDefault(x => x.ID == _user.ID);
            try
            {

                if (FNameTB.Text == "" && string.IsNullOrEmpty(FNameTB.Text))
                {
                    MessageBox.Show("Enter First Name ");
                }
                if (LNameTB.Text == "" && string.IsNullOrEmpty(LNameTB.Text))
                {
                    MessageBox.Show("Enter Last Name ");

                }
                if (ParishTB.Text == "" && string.IsNullOrEmpty(ParishTB.Text))
                {
                    MessageBox.Show("Enter The  Parish In Which You Live ");
                }
                if (StreetTB.Text == "" && string.IsNullOrEmpty(StreetTB.Text))
                {
                    MessageBox.Show("Enter The Street Name For Where You Live ");
                }
                if (ZipcodeTB.Text == "" && string.IsNullOrEmpty(ZipcodeTB.Text))
                {
                    MessageBox.Show("Enter Your Countries Zipcode ");
                }
                if (OccupationTB.Text == "" && string.IsNullOrEmpty(OccupationTB.Text))
                {
                    MessageBox.Show("Enter Your Occupation ");
                }
                if (PhoneNumberTB.Text == "(   )    -")
                {
                    MessageBox.Show("Enter Your PhoneNumber");
                }

                var First = FNameTB.Text;
                var Last = LNameTB.Text;
                var Parish = ParishTB.Text;
                var Street = StreetTB.Text;
                var ZipCode = ZipcodeTB.Text;
                var Occupation = OccupationTB.Text;
                var Phone = PhoneNumberTB.Text;
                var id = user.ID;

                var person = new Person_Table
                {
                    First_Name = First,
                    Last_Name = Last,
                    Parish = Parish,
                    Street = Street,
                    ZIP_Code = ZipCode,
                    Occupation = Occupation,
                    Telephone = Phone,
                    UserID = id
                };

                int myNumber;
                bool test1 = true;
                bool test2 = true;
                bool test3 = true;
                bool test4 = true;
                if (int.TryParse(First, out myNumber) == true)
                {
                    test1 = false;
                }
                if (int.TryParse(Last, out myNumber) == true)
                {
                    test2 = false;
                }
                if (int.TryParse(Parish, out myNumber) == true)
                {
                    test3 = false;
                }
                if (int.TryParse(Occupation, out myNumber) == true)
                {
                    test4 = false;
                }
                if (!string.IsNullOrEmpty(StreetTB.Text))
                {
                    if (!string.IsNullOrEmpty(ZipcodeTB.Text))
                    {

                        if (PhoneNumberTB.Text != "(   )    -")
                        {
                            if (test1 == false && test2 == false && test3 == false && test4 == false)
                            {
                                MessageBox.Show("Check To Ensure All Field Data Are Correct");
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
                            if (!test1 == false && !test2 == false && !test3 == false && !test4 == false)
                            {
                                _db.Person_Tables.Add(person);
                                _db.SaveChanges();
                                var personid = person.ID;

                                MessageBox.Show("New Person Updated Succesfully");

                                this.Close();
                                var createprofile = new Creating_profile_page_2(_user);
                                createprofile.Show();
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
