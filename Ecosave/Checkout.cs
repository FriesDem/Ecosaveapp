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
    public partial class Checkout : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Checkout(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }

        private void CardInfo_Click(object sender, EventArgs e)
        {
            var person = _db.Person_Tables.FirstOrDefault(x => x.UserID == _user.ID);
            {
                Cnum.Text = person.CardNumber;
                Cexp.Text = person.CardExperation;
                Ccvv.Text = person.CardCvv;
            }
                if (Cnum.Visible == false)
            {
                Cnum.Visible = true;
                cnumber.Visible = true;
                Cexp.Visible = true;
                cexperation.Visible = true;
                Ccvv.Visible = true;
                cccv.Visible = true;
                submit.Visible = true;
            }
            else
            {
                Cnum.Visible = false;
                cnumber.Visible = false;
                Cexp.Visible = false;
                cexperation.Visible = false;
                Ccvv.Visible = false;
                cccv.Visible = false;
                submit.Visible = false;
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            var user = _db.Items.FirstOrDefault(x => x.UserID == _user.ID);
            if (user == null)
            {
                MessageBox.Show("Invalid User");
                return;
            }
            if (user != null)
            {
                PopulateGrid();
            }
            Cnum.Visible = false;
            cnumber.Visible = false;
            Cexp.Visible = false;
            cexperation.Visible = false;
            Ccvv.Visible = false;
            cccv.Visible = false;
            submit.Visible = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var person = _db.Person_Tables.FirstOrDefault(x => x.UserID == _user.ID);
            {
                
                if (person == null)
                {
                    MessageBox.Show("Invalid User");
                    return;
                }
                if (person != null)
                {
                    if (Cnum.Text != "")
                    {
                        
                        person.CardNumber = Cnum.Text;
                       
                        _db.SaveChanges();
                    }
                    if (Cexp.Text != "")
                    {
                        person.CardExperation = Cexp.Text;
                  
                        _db.SaveChanges();
                    }
                    if (Ccvv.Text != "")
                    
                        person.CardCvv = Ccvv.Text;
                   
                        _db.SaveChanges();
                    }
                }
            }
        public void PopulateGrid()
        {
           

            var Eco = _db.Items.Select
           (q => new
            {
                q.ID,
                q.Type,
                q.Name,
                q.Amount,
                q.Cost
            })
            .ToList();
            Store.DataSource = Eco;
            Store.Columns["Name"].HeaderText = "Name";
            Store.Columns["Cost"].HeaderText = "Cost";
            Store.Columns["Amount"].HeaderText = "Amount";
            Store.Columns["ID"].Visible = false;
            Store.Columns["Type"].Visible = false;
        }
    }
    }


