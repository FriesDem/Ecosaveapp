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
    public partial class Creating_profile_page_2 : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Creating_profile_page_2(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }

        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void SUYASubBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                var HowRooms = int.Parse(HowManyRoomsTB.Text);
                var HowDevices = int.Parse(HowManyDeviceTB.Text);
                var occupants  = int.Parse(OccupantsTB.Text);
                var Budget     = int.Parse(BudgetTB.Text); 
                var income = int.Parse(IncomeTB.Text) ;


                var person = _db.Person_Tables.FirstOrDefault(x => x.UserID == _user.ID);
                {
                    person.Number_of_Houses = HowRooms;
                    person.Number_of_Devices = HowDevices;
                    person.Number_of_Occupants = occupants;
                    person.Budget_for_Utilities = Budget;
                    person.Income = income;              
                };
               
                _db.SaveChanges();
                MessageBox.Show("Welcome To Eco Save");
                this.Close();
                LoginForm log = new LoginForm();
                log.Show();
            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
        }
    }
}
