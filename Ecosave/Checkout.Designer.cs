namespace Ecosave
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.cccv = new System.Windows.Forms.Label();
            this.cexperation = new System.Windows.Forms.Label();
            this.cnumber = new System.Windows.Forms.Label();
            this.Ccvv = new System.Windows.Forms.MaskedTextBox();
            this.Cexp = new System.Windows.Forms.MaskedTextBox();
            this.Cnum = new System.Windows.Forms.MaskedTextBox();
            this.CardInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Amountselect = new System.Windows.Forms.NumericUpDown();
            this.Checkoutbtn = new System.Windows.Forms.Button();
            this.deleteorder = new System.Windows.Forms.Button();
            this.Store = new System.Windows.Forms.DataGridView();
            this.SubmitAmount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amountselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitAmount);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.cccv);
            this.panel1.Controls.Add(this.cexperation);
            this.panel1.Controls.Add(this.cnumber);
            this.panel1.Controls.Add(this.Ccvv);
            this.panel1.Controls.Add(this.Cexp);
            this.panel1.Controls.Add(this.Cnum);
            this.panel1.Controls.Add(this.CardInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.Amountselect);
            this.panel1.Controls.Add(this.Checkoutbtn);
            this.panel1.Controls.Add(this.deleteorder);
            this.panel1.Controls.Add(this.Store);
            this.panel1.Location = new System.Drawing.Point(320, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 785);
            this.panel1.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PowderBlue;
            this.submit.Location = new System.Drawing.Point(1120, 292);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(129, 32);
            this.submit.TabIndex = 90;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cccv
            // 
            this.cccv.AutoSize = true;
            this.cccv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cccv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cccv.Location = new System.Drawing.Point(1123, 214);
            this.cccv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cccv.Name = "cccv";
            this.cccv.Size = new System.Drawing.Size(127, 29);
            this.cccv.TabIndex = 89;
            this.cccv.Text = "Card CCV";
            // 
            // cexperation
            // 
            this.cexperation.AutoSize = true;
            this.cexperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cexperation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cexperation.Location = new System.Drawing.Point(1055, 148);
            this.cexperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cexperation.Name = "cexperation";
            this.cexperation.Size = new System.Drawing.Size(194, 29);
            this.cexperation.TabIndex = 88;
            this.cexperation.Text = "Card Experation";
            // 
            // cnumber
            // 
            this.cnumber.AutoSize = true;
            this.cnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cnumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cnumber.Location = new System.Drawing.Point(1085, 76);
            this.cnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cnumber.Name = "cnumber";
            this.cnumber.Size = new System.Drawing.Size(164, 29);
            this.cnumber.TabIndex = 87;
            this.cnumber.Text = "Card Number";
            // 
            // Ccvv
            // 
            this.Ccvv.Location = new System.Drawing.Point(1191, 246);
            this.Ccvv.Mask = "000";
            this.Ccvv.Name = "Ccvv";
            this.Ccvv.Size = new System.Drawing.Size(59, 22);
            this.Ccvv.TabIndex = 86;
            this.Ccvv.ValidatingType = typeof(int);
            // 
            // Cexp
            // 
            this.Cexp.Location = new System.Drawing.Point(1191, 180);
            this.Cexp.Mask = "00/00";
            this.Cexp.Name = "Cexp";
            this.Cexp.Size = new System.Drawing.Size(59, 22);
            this.Cexp.TabIndex = 85;
            // 
            // Cnum
            // 
            this.Cnum.Location = new System.Drawing.Point(1106, 108);
            this.Cnum.Mask = "0000 0000 0000 0000";
            this.Cnum.Name = "Cnum";
            this.Cnum.Size = new System.Drawing.Size(144, 22);
            this.Cnum.TabIndex = 84;
            // 
            // CardInfo
            // 
            this.CardInfo.BackColor = System.Drawing.Color.PowderBlue;
            this.CardInfo.Location = new System.Drawing.Point(1037, 27);
            this.CardInfo.Name = "CardInfo";
            this.CardInfo.Size = new System.Drawing.Size(213, 34);
            this.CardInfo.TabIndex = 83;
            this.CardInfo.Text = "Add/Edit Card Info";
            this.CardInfo.UseVisualStyleBackColor = false;
            this.CardInfo.Click += new System.EventHandler(this.CardInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "Item Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(537, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 29);
            this.label10.TabIndex = 74;
            this.label10.Text = "Cart";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLbl.Location = new System.Drawing.Point(476, 0);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(234, 29);
            this.NameLbl.TabIndex = 73;
            this.NameLbl.Text = "Eco Save Solutions";
            // 
            // Amountselect
            // 
            this.Amountselect.Location = new System.Drawing.Point(52, 337);
            this.Amountselect.Name = "Amountselect";
            this.Amountselect.Size = new System.Drawing.Size(44, 22);
            this.Amountselect.TabIndex = 3;
            this.Amountselect.ValueChanged += new System.EventHandler(this.Amountslect_ValueChanged);
            // 
            // Checkoutbtn
            // 
            this.Checkoutbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.Checkoutbtn.Location = new System.Drawing.Point(988, 628);
            this.Checkoutbtn.Name = "Checkoutbtn";
            this.Checkoutbtn.Size = new System.Drawing.Size(129, 32);
            this.Checkoutbtn.TabIndex = 2;
            this.Checkoutbtn.Text = "Checkout";
            this.Checkoutbtn.UseVisualStyleBackColor = false;
            this.Checkoutbtn.Click += new System.EventHandler(this.Checkoutbtn_Click);
            // 
            // deleteorder
            // 
            this.deleteorder.BackColor = System.Drawing.Color.PowderBlue;
            this.deleteorder.Location = new System.Drawing.Point(52, 132);
            this.deleteorder.Name = "deleteorder";
            this.deleteorder.Size = new System.Drawing.Size(75, 31);
            this.deleteorder.TabIndex = 1;
            this.deleteorder.Text = "Delete";
            this.deleteorder.UseVisualStyleBackColor = false;
            this.deleteorder.Click += new System.EventHandler(this.deleteorder_Click);
            // 
            // Store
            // 
            this.Store.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Store.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.Store.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Store.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Store.GridColor = System.Drawing.Color.SteelBlue;
            this.Store.Location = new System.Drawing.Point(239, 132);
            this.Store.Name = "Store";
            this.Store.RowHeadersWidth = 51;
            this.Store.RowTemplate.Height = 24;
            this.Store.Size = new System.Drawing.Size(675, 528);
            this.Store.TabIndex = 0;
            // 
            // SubmitAmount
            // 
            this.SubmitAmount.BackColor = System.Drawing.Color.PowderBlue;
            this.SubmitAmount.Location = new System.Drawing.Point(114, 337);
            this.SubmitAmount.Name = "SubmitAmount";
            this.SubmitAmount.Size = new System.Drawing.Size(75, 27);
            this.SubmitAmount.TabIndex = 91;
            this.SubmitAmount.Text = "Submit";
            this.SubmitAmount.UseVisualStyleBackColor = false;
            this.SubmitAmount.Click += new System.EventHandler(this.SubmitAmount_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1102);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amountselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Store;
        private System.Windows.Forms.NumericUpDown Amountselect;
        private System.Windows.Forms.Button Checkoutbtn;
        private System.Windows.Forms.Button deleteorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label cccv;
        private System.Windows.Forms.Label cexperation;
        private System.Windows.Forms.Label cnumber;
        private System.Windows.Forms.MaskedTextBox Ccvv;
        private System.Windows.Forms.MaskedTextBox Cexp;
        private System.Windows.Forms.MaskedTextBox Cnum;
        private System.Windows.Forms.Button CardInfo;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button SubmitAmount;
    }
}