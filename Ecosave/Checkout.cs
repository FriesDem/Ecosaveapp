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
                MessageBox.Show("Go To The Shop And Buy Stuff For Them To BE Added To Your Cart");
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
                try
                {

                    if (person == null)
                    {
                        MessageBox.Show("Please Validate Who You Are");
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


                catch (Exception)
                {

                    MessageBox.Show("Unfortunate Error");
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
            try
            {
                var ID = (int)Store.SelectedRows[0].Cells["ID"].Value;

                //query Database 

                var delete = _db.Items.FirstOrDefault(Queryable => Queryable.ID == ID);
                {
                    _db.Items.Remove(delete);
                }

                _db.SaveChanges();
                PopulateGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("Select Row To Edit");
            }
           

        }

        private void Amountslect_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var ID = (int)Store.SelectedRows[0].Cells["ID"].Value;

                var item = _db.Items.FirstOrDefault(Queryable => Queryable.ID == ID);
                {
                    var itemamount = Amountselect.Value.ToString();
                    item.Amount = int.Parse(itemamount);
                }

                _db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Select Row To Edit");

            }
         

        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var person = _db.Person_Tables.FirstOrDefault(x => x.UserID == _user.ID);
                {
                    if (person == null)
                    {
                        MessageBox.Show("Check To Ensure All Your Details Are Correct");
                    }

                    if (person.CardNumber == null)
                    {

                        MessageBox.Show("Input Card Number info");
                    }
                    if (person.CardExperation == null)
                    {
                        MessageBox.Show("Input Card Date info");
                    }
                    if (person.CardCvv == null)
                    {
                        MessageBox.Show("Input Card  Ccvv info");
                    }

                    if (person.CardNumber != null && person.CardExperation != null && person.CardCvv != null)
                    {
                        
                        var Sum = _db.Items.Where(x => x.UserID == _user.ID && x.IsActive == true).Sum(x => x.Amount * x.Cost);
                        MessageBox.Show("Total Amount To Be Paid Is :" + Sum);
                        MessageBox.Show("Your Account Will BE Charged Within 3-4 Working Days");
                        
                        for(int i = 0; i < 100; i++)
                        {
                            var item = _db.Items.FirstOrDefault(x => x.UserID == _user.ID && x.IsActive == true);
                          
                            {
                                item.IsActive = false;
                            }
                        }
                        
                    }
                    _db.SaveChanges();
                    PopulateGrid();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An Unforseen Error Has Occured");
            }
          
        }

        private void SubmitAmount_Click(object sender, EventArgs e)
        {
            _db.SaveChanges();
            PopulateGrid();
        }
    }
    }


