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
    public partial class EF_ECOFLOW_Solar_Generator_Delta_Max : Form
    {
        private readonly ECOSAVEEntities _db;
        private User _user;
        public EF_ECOFLOW_Solar_Generator_Delta_Max(User user)
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
            var Itemcost = 6370;
            var itemname = "EF_ECOFLOW_Solar_Generator_Delta_Max";
            var itemtype = "SolarGenerator";
            var itemamount = 1;
            var store = new Item
            {
                UserID = userid,
                Cost = Itemcost,
                Name = itemname,
                Type = itemtype,
                Amount = itemamount
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
            var Itemcost = 6370;
            var itemname = "EF_ECOFLOW_Solar_Generator_Delta_Max";
            var itemtype = "SolarGenerator";
            var itemamount = 1;
            var store = new Item
            {
                UserID = userid,
                Cost = Itemcost,
                Name = itemname,
                Type = itemtype,
                Amount = itemamount
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
