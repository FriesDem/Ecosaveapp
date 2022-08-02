namespace Ecosave
{
    partial class Billing_Table_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing_Table_Screen));
            this.cmboReadingType = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Label();
            this.BacklogoBtn = new System.Windows.Forms.PictureBox();
            this.txtDemandCharge = new System.Windows.Forms.TextBox();
            this.txtIPPCharge = new System.Windows.Forms.TextBox();
            this.lblFinalCharge = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerCharge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnergyCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnergyUsed = new System.Windows.Forms.TextBox();
            this.txtFuelCharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboReadingType
            // 
            this.cmboReadingType.FormattingEnabled = true;
            this.cmboReadingType.Items.AddRange(new object[] {
            "Actual",
            "Previous"});
            this.cmboReadingType.Location = new System.Drawing.Point(723, 555);
            this.cmboReadingType.Margin = new System.Windows.Forms.Padding(4);
            this.cmboReadingType.Name = "cmboReadingType";
            this.cmboReadingType.Size = new System.Drawing.Size(208, 24);
            this.cmboReadingType.TabIndex = 62;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(779, 695);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 28);
            this.submitBtn.TabIndex = 61;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1331, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 1028);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(640, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "Your Last Bill\'s Information";
            // 
            // Backbtn
            // 
            this.Backbtn.AutoSize = true;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(56, 13);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(56, 25);
            this.Backbtn.TabIndex = 58;
            this.Backbtn.Text = "Back";
            // 
            // BacklogoBtn
            // 
            this.BacklogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.BacklogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("BacklogoBtn.Image")));
            this.BacklogoBtn.Location = new System.Drawing.Point(3, 13);
            this.BacklogoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BacklogoBtn.Name = "BacklogoBtn";
            this.BacklogoBtn.Size = new System.Drawing.Size(53, 34);
            this.BacklogoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BacklogoBtn.TabIndex = 57;
            this.BacklogoBtn.TabStop = false;
            // 
            // txtDemandCharge
            // 
            this.txtDemandCharge.BackColor = System.Drawing.Color.SteelBlue;
            this.txtDemandCharge.Location = new System.Drawing.Point(723, 663);
            this.txtDemandCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtDemandCharge.Name = "txtDemandCharge";
            this.txtDemandCharge.Size = new System.Drawing.Size(208, 22);
            this.txtDemandCharge.TabIndex = 51;
            // 
            // txtIPPCharge
            // 
            this.txtIPPCharge.BackColor = System.Drawing.Color.SteelBlue;
            this.txtIPPCharge.Location = new System.Drawing.Point(723, 624);
            this.txtIPPCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtIPPCharge.Name = "txtIPPCharge";
            this.txtIPPCharge.Size = new System.Drawing.Size(208, 22);
            this.txtIPPCharge.TabIndex = 50;
            // 
            // lblFinalCharge
            // 
            this.lblFinalCharge.AutoSize = true;
            this.lblFinalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFinalCharge.Location = new System.Drawing.Point(965, 450);
            this.lblFinalCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalCharge.Name = "lblFinalCharge";
            this.lblFinalCharge.Size = new System.Drawing.Size(23, 25);
            this.lblFinalCharge.TabIndex = 49;
            this.lblFinalCharge.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(965, 420);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "Final Charge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(507, 663);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Demand Charge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(507, 623);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "IPP Charge";
            // 
            // txtCustomerCharge
            // 
            this.txtCustomerCharge.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCustomerCharge.Location = new System.Drawing.Point(723, 592);
            this.txtCustomerCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerCharge.Name = "txtCustomerCharge";
            this.txtCustomerCharge.Size = new System.Drawing.Size(208, 22);
            this.txtCustomerCharge.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(507, 590);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Customer Charge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(507, 556);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Reading Type";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.BackColor = System.Drawing.Color.SteelBlue;
            this.txtExchangeRate.Location = new System.Drawing.Point(723, 523);
            this.txtExchangeRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(208, 22);
            this.txtExchangeRate.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(507, 524);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Exchange Rate";
            // 
            // txtEnergyCharge
            // 
            this.txtEnergyCharge.BackColor = System.Drawing.Color.SteelBlue;
            this.txtEnergyCharge.Location = new System.Drawing.Point(723, 482);
            this.txtEnergyCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnergyCharge.Name = "txtEnergyCharge";
            this.txtEnergyCharge.Size = new System.Drawing.Size(208, 22);
            this.txtEnergyCharge.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(507, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Energy Charge";
            // 
            // txtEnergyUsed
            // 
            this.txtEnergyUsed.BackColor = System.Drawing.Color.SteelBlue;
            this.txtEnergyUsed.Location = new System.Drawing.Point(723, 420);
            this.txtEnergyUsed.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnergyUsed.Name = "txtEnergyUsed";
            this.txtEnergyUsed.Size = new System.Drawing.Size(208, 22);
            this.txtEnergyUsed.TabIndex = 55;
            // 
            // txtFuelCharge
            // 
            this.txtFuelCharge.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFuelCharge.Location = new System.Drawing.Point(723, 450);
            this.txtFuelCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuelCharge.Name = "txtFuelCharge";
            this.txtFuelCharge.Size = new System.Drawing.Size(208, 22);
            this.txtFuelCharge.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(507, 417);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Energy Used (kWh)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(507, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fuel Charge";
            // 
            // Billing_Table_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1906, 1008);
            this.Controls.Add(this.cmboReadingType);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.BacklogoBtn);
            this.Controls.Add(this.txtDemandCharge);
            this.Controls.Add(this.txtIPPCharge);
            this.Controls.Add(this.lblFinalCharge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerCharge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnergyCharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnergyUsed);
            this.Controls.Add(this.txtFuelCharge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Billing_Table_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing_Table_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboReadingType;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Backbtn;
        private System.Windows.Forms.PictureBox BacklogoBtn;
        private System.Windows.Forms.TextBox txtDemandCharge;
        private System.Windows.Forms.TextBox txtIPPCharge;
        private System.Windows.Forms.Label lblFinalCharge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerCharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnergyCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnergyUsed;
        private System.Windows.Forms.TextBox txtFuelCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}