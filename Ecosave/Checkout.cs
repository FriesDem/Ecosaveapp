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

            
            var Eco = _db.Items.Where(x =>x.UserID == _user.ID && x.IsActive == true).Select
           (q => new
            {  
              q.ID,
              q.Type,
              q.Name,
              q.IsActive,
              q.Amount,
              q.Cost
            })
            .ToList();
            Store.DataSource = Eco;
            Store.Columns["Name"].HeaderText = "Name";
            Store.Columns["Cost"].HeaderText = "Cost";
            Store.Columns["Amount"].HeaderText = "Amount";
            Store.Columns["ID"].Visible = false;
            Store.Columns["IsActive"].Visible = false;
            Store.Columns["Type"].Visible = false;
        }

        private void deleteorder_Click(object sender, EventArgs e)
        {
            var ID = (int)Store.SelectedRows[0].Cells["ID"].Value;

            //query Database 

            var delete = _db.Items.FirstOrDefault(Queryable => Queryable.ID == ID);
            {
                delete.IsActive = false;
            }

            _db.SaveChanges();
        }

        private void Amountslect_ValueChanged(object sender, EventArgs e)
        {
            var ID = (int)Store.SelectedRows[0].Cells["ID"].Value;

          var item = _db.Items.FirstOrDefault(Queryable => Queryable.ID == ID);
            {
                var itemamount = Amountselect.Value.ToString();
                item.Amount = int.Parse(itemamount);
            }
            
            _db.SaveChanges();

        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
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
                    if (person.CardNumber != "")
                    {

                        MessageBox.Show("Input Card info");
                    }
                    if (person.CardExperation != "")
                    {
                        MessageBox.Show("Input Card info");
                    }
                    if (person.CardCvv != "")

                        MessageBox.Show("Input Card info");
                }
            }
            MessageBox.Show("Thanks For Shopping With Us We Will Email You With Your Package Information in 2-3 Buisness Days ( Also Duely Note Transactions take 1-2 Buisness Days )");
        }

        private void SubmitAmount_Click(object sender, EventArgs e)
        {
            _db.SaveChanges();
            PopulateGrid();
        }
    }
    }


