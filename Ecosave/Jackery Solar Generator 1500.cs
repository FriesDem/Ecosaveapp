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
    public partial class Jackery_Solar_Generator_1500 : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public Jackery_Solar_Generator_1500(User user)
        {
            InitializeComponent();
            _db = new ECOSAVEEntities();
            _user = user;
        }
       
        private void BacklogoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyNow_Click(object sender, EventArgs e)
        {
            var userid = _user.ID;
            var Itemcost = 5600;
            var itemname = "Jackery_Solar_Generator_1500";
            var itemtype = "SolarGenerator";
            var itemamount = 1;
            var store = new Item
            {
                UserID = userid,
                Cost = Itemcost,
                Name = itemname,
                Type = itemtype,
                Amount = itemamount,
                IsActive = true
            };
            _db.Items.Add(store);
            _db.SaveChanges();



            if (!Utils.FormIsOpen("Checkout"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Checkout = new Checkout(_user);
                Checkout.MdiParent = this.MdiParent;
                Checkout.Show();

            }
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            var userid = _user.ID;
            var Itemcost = 5600;
            var itemname = "Jackery_Solar_Generator_1500";
            var itemtype = "SolarGenerator";
            var itemamount = 1;
            var store = new Item
            {
                UserID = userid,
                Cost = Itemcost,
                Name = itemname,
                Type = itemtype,
                Amount = itemamount,
                IsActive = true
            };
            _db.Items.Add(store);
            _db.SaveChanges();



            if (!Utils.FormIsOpen("Checkout"))
            {

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                var Checkout = new Checkout(_user);
                Checkout.MdiParent = this.MdiParent;
                Checkout.Show();

            }
        }
    }
}
