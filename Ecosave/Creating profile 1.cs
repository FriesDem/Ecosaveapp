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


        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            var user = _db.Users.FirstOrDefault(x => x.ID == _user.ID);
            try
            {
               var test1 = FNameTB.ToString();

                if (FNameTB.Text == "")
                {
                    MessageBox.Show("Enter First Name ");
                }
                if (LNameTB.Text == "")
                {
                    MessageBox.Show("Enter Last Name ");

                }
                if (ParishTB.Text == "")
                {
                    MessageBox.Show("Enter The  Parish In Which You Live ");
                }
                if (StreetTB.Text == "")
                {
                    MessageBox.Show("Enter The Street Name For Where You Live ");
                }
                if (ZipcodeTB.Text == "")
                {
                    MessageBox.Show("Enter Your Countries Zipcode ");
                }
                if (OccupationTB.Text == "")
                {
                    MessageBox.Show("Enter Your Occupation ");
                }
                if (PhoneNumberTB.Text == "" )
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
                _db.Person_Tables.Add(person);
                _db.SaveChanges();
                var personid = person.ID;

                MessageBox.Show("New Person Updated Succesfully");

                this.Close();
                var createprofile = new Creating_profile_page_2(_user);
                createprofile.Show();
            }
            
            catch (Exception)
            {

                MessageBox.Show("Error");
            }    
               
        }
    }
}
