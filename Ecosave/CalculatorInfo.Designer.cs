namespace Ecosave
{
    partial class BillingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingPage));
            this.Backbtn = new System.Windows.Forms.Label();
            this.BacklogoBtn = new System.Windows.Forms.PictureBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnergyUsed = new System.Windows.Forms.TextBox();
            this.txtFuelCharge = new System.Windows.Forms.TextBox();
            this.txtEnergyCharge = new System.Windows.Forms.TextBox();
            this.txtExRate = new System.Windows.Forms.TextBox();
            this.txtReadingType = new System.Windows.Forms.TextBox();
            this.txtCustomerCharge = new System.Windows.Forms.TextBox();
            this.txtIPPCharge = new System.Windows.Forms.TextBox();
            this.txtDemandCharge = new System.Windows.Forms.TextBox();
            this.lblFinalCharge = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.AutoSize = true;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(67, 14);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(56, 25);
            this.Backbtn.TabIndex = 26;
            this.Backbtn.Text = "Back";
            // 
            // BacklogoBtn
            // 
            this.BacklogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.BacklogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("BacklogoBtn.Image")));
            this.BacklogoBtn.Location = new System.Drawing.Point(13, 14);
            this.BacklogoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BacklogoBtn.Name = "BacklogoBtn";
            this.BacklogoBtn.Size = new System.Drawing.Size(53, 34);
            this.BacklogoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BacklogoBtn.TabIndex = 25;
            this.BacklogoBtn.TabStop = false;
            this.BacklogoBtn.Click += new System.EventHandler(this.BacklogoBtn_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(644, 635);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(123, 36);
            this.btnsubmit.TabIndex = 27;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtEnergyUsed, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFuelCharge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEnergyCharge, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtExRate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtReadingType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerCharge, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtIPPCharge, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDemandCharge, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblFinalCharge, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(395, 201);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 428);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Energy Used (kWh)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fuel Charge ($ per kWh)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Energy Charge ($ per kWh)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(4, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(4, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reading Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(4, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Charge ($)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(4, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "IPP Charge ($ per kWh)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(4, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Demand Charge";
            // 
            // txtEnergyUsed
            // 
            this.txtEnergyUsed.Location = new System.Drawing.Point(379, 4);
            this.txtEnergyUsed.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnergyUsed.Name = "txtEnergyUsed";
            this.txtEnergyUsed.Size = new System.Drawing.Size(132, 22);
            this.txtEnergyUsed.TabIndex = 1;
            // 
            // txtFuelCharge
            // 
            this.txtFuelCharge.Location = new System.Drawing.Point(379, 51);
            this.txtFuelCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuelCharge.Name = "txtFuelCharge";
            this.txtFuelCharge.Size = new System.Drawing.Size(132, 22);
            this.txtFuelCharge.TabIndex = 1;
            // 
            // txtEnergyCharge
            // 
            this.txtEnergyCharge.Location = new System.Drawing.Point(379, 98);
            this.txtEnergyCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnergyCharge.Name = "txtEnergyCharge";
            this.txtEnergyCharge.Size = new System.Drawing.Size(132, 22);
            this.txtEnergyCharge.TabIndex = 1;
            // 
            // txtExRate
            // 
            this.txtExRate.Location = new System.Drawing.Point(379, 145);
            this.txtExRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExRate.Name = "txtExRate";
            this.txtExRate.Size = new System.Drawing.Size(132, 22);
            this.txtExRate.TabIndex = 1;
            // 
            // txtReadingType
            // 
            this.txtReadingType.Location = new System.Drawing.Point(379, 192);
            this.txtReadingType.Margin = new System.Windows.Forms.Padding(4);
            this.txtReadingType.Name = "txtReadingType";
            this.txtReadingType.Size = new System.Drawing.Size(132, 22);
            this.txtReadingType.TabIndex = 1;
            // 
            // txtCustomerCharge
            // 
            this.txtCustomerCharge.Location = new System.Drawing.Point(379, 239);
            this.txtCustomerCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerCharge.Name = "txtCustomerCharge";
            this.txtCustomerCharge.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerCharge.TabIndex = 1;
            // 
            // txtIPPCharge
            // 
            this.txtIPPCharge.Location = new System.Drawing.Point(379, 286);
            this.txtIPPCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtIPPCharge.Name = "txtIPPCharge";
            this.txtIPPCharge.Size = new System.Drawing.Size(132, 22);
            this.txtIPPCharge.TabIndex = 1;
            // 
            // txtDemandCharge
            // 
            this.txtDemandCharge.Location = new System.Drawing.Point(379, 333);
            this.txtDemandCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtDemandCharge.Name = "txtDemandCharge";
            this.txtDemandCharge.Size = new System.Drawing.Size(132, 22);
            this.txtDemandCharge.TabIndex = 1;
            // 
            // lblFinalCharge
            // 
            this.lblFinalCharge.AutoSize = true;
            this.lblFinalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFinalCharge.Location = new System.Drawing.Point(379, 376);
            this.lblFinalCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalCharge.Name = "lblFinalCharge";
            this.lblFinalCharge.Size = new System.Drawing.Size(0, 29);
            this.lblFinalCharge.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(4, 376);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Final Charge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(343, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(737, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Enter your Previous Billing Information in the respective fields below";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1471, -108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(779, 635);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 36);
            this.clear.TabIndex = 89;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // BillingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.BacklogoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BillingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Backbtn;
        private System.Windows.Forms.PictureBox BacklogoBtn;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnergyUsed;
        private System.Windows.Forms.TextBox txtFuelCharge;
        private System.Windows.Forms.TextBox txtEnergyCharge;
        private System.Windows.Forms.TextBox txtExRate;
        private System.Windows.Forms.TextBox txtReadingType;
        private System.Windows.Forms.TextBox txtCustomerCharge;
        private System.Windows.Forms.TextBox txtIPPCharge;
        private System.Windows.Forms.TextBox txtDemandCharge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFinalCharge;
        private System.Windows.Forms.Label label9;
      
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clear;
    }
}