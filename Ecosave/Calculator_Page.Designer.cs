namespace Ecosave
{
    partial class Calculator_Page
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator_Page));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Backbtn = new System.Windows.Forms.Label();
            this.BacklogoBtn = new System.Windows.Forms.PictureBox();
            this.tblCalculator = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoursUsed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWeeklyCostDisplay = new System.Windows.Forms.Label();
            this.lblDailyCostDisplay = new System.Windows.Forms.Label();
            this.lblYearlyCostDisplay = new System.Windows.Forms.Label();
            this.lblMonthlyCostDisplay = new System.Windows.Forms.Label();
            this.txtPowerOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboDeviceSelect = new System.Windows.Forms.ComboBox();
            this.devicesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).BeginInit();
            this.tblCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(556, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 87;
            this.label2.Text = "Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1470, -103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // Backbtn
            // 
            this.Backbtn.AutoSize = true;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(67, 49);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(56, 25);
            this.Backbtn.TabIndex = 79;
            this.Backbtn.Text = "Back";
            // 
            // BacklogoBtn
            // 
            this.BacklogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.BacklogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("BacklogoBtn.Image")));
            this.BacklogoBtn.Location = new System.Drawing.Point(13, 49);
            this.BacklogoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BacklogoBtn.Name = "BacklogoBtn";
            this.BacklogoBtn.Size = new System.Drawing.Size(53, 34);
            this.BacklogoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BacklogoBtn.TabIndex = 78;
            this.BacklogoBtn.TabStop = false;
            this.BacklogoBtn.Click += new System.EventHandler(this.BacklogoBtn_Click);
            // 
            // tblCalculator
            // 
            this.tblCalculator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCalculator.ColumnCount = 2;
            this.tblCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.98266F));
            this.tblCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.68401F));
            this.tblCalculator.Controls.Add(this.label7, 0, 5);
            this.tblCalculator.Controls.Add(this.label8, 0, 6);
            this.tblCalculator.Controls.Add(this.label9, 0, 7);
            this.tblCalculator.Controls.Add(this.label3, 0, 1);
            this.tblCalculator.Controls.Add(this.label4, 0, 2);
            this.tblCalculator.Controls.Add(this.txtHoursUsed, 1, 2);
            this.tblCalculator.Controls.Add(this.label6, 0, 4);
            this.tblCalculator.Controls.Add(this.lblWeeklyCostDisplay, 1, 5);
            this.tblCalculator.Controls.Add(this.lblDailyCostDisplay, 1, 4);
            this.tblCalculator.Controls.Add(this.lblYearlyCostDisplay, 1, 7);
            this.tblCalculator.Controls.Add(this.lblMonthlyCostDisplay, 1, 6);
            this.tblCalculator.Controls.Add(this.txtPowerOutput, 1, 1);
            this.tblCalculator.Controls.Add(this.label1, 0, 0);
            this.tblCalculator.Controls.Add(this.cmboDeviceSelect, 1, 0);
            this.tblCalculator.Location = new System.Drawing.Point(268, 146);
            this.tblCalculator.Margin = new System.Windows.Forms.Padding(4);
            this.tblCalculator.Name = "tblCalculator";
            this.tblCalculator.RowCount = 8;
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblCalculator.Size = new System.Drawing.Size(716, 423);
            this.tblCalculator.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(4, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weekly Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(4, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Monthly Cost";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(4, 364);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yearly Cost";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Power Output (Watts)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(4, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hours Used (h)";
            // 
            // txtHoursUsed
            // 
            this.txtHoursUsed.Location = new System.Drawing.Point(422, 108);
            this.txtHoursUsed.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoursUsed.Name = "txtHoursUsed";
            this.txtHoursUsed.Size = new System.Drawing.Size(136, 22);
            this.txtHoursUsed.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(4, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Daily Cost ";
            // 
            // lblWeeklyCostDisplay
            // 
            this.lblWeeklyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWeeklyCostDisplay.Location = new System.Drawing.Point(422, 260);
            this.lblWeeklyCostDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeeklyCostDisplay.Name = "lblWeeklyCostDisplay";
            this.lblWeeklyCostDisplay.Size = new System.Drawing.Size(289, 39);
            this.lblWeeklyCostDisplay.TabIndex = 0;
            // 
            // lblDailyCostDisplay
            // 
            this.lblDailyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDailyCostDisplay.Location = new System.Drawing.Point(422, 208);
            this.lblDailyCostDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDailyCostDisplay.Name = "lblDailyCostDisplay";
            this.lblDailyCostDisplay.Size = new System.Drawing.Size(289, 39);
            this.lblDailyCostDisplay.TabIndex = 0;
            // 
            // lblYearlyCostDisplay
            // 
            this.lblYearlyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblYearlyCostDisplay.Location = new System.Drawing.Point(422, 364);
            this.lblYearlyCostDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearlyCostDisplay.Name = "lblYearlyCostDisplay";
            this.lblYearlyCostDisplay.Size = new System.Drawing.Size(289, 39);
            this.lblYearlyCostDisplay.TabIndex = 0;
            // 
            // lblMonthlyCostDisplay
            // 
            this.lblMonthlyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMonthlyCostDisplay.Location = new System.Drawing.Point(422, 312);
            this.lblMonthlyCostDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyCostDisplay.Name = "lblMonthlyCostDisplay";
            this.lblMonthlyCostDisplay.Size = new System.Drawing.Size(289, 39);
            this.lblMonthlyCostDisplay.TabIndex = 0;
            // 
            // txtPowerOutput
            // 
            this.txtPowerOutput.Location = new System.Drawing.Point(422, 56);
            this.txtPowerOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtPowerOutput.Name = "txtPowerOutput";
            this.txtPowerOutput.Size = new System.Drawing.Size(136, 22);
            this.txtPowerOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device";
            // 
            // cmboDeviceSelect
            // 
            this.cmboDeviceSelect.DataSource = this.devicesTableBindingSource;
            this.cmboDeviceSelect.DisplayMember = "Type Of Device";
            this.cmboDeviceSelect.FormattingEnabled = true;
            this.cmboDeviceSelect.Location = new System.Drawing.Point(422, 4);
            this.cmboDeviceSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmboDeviceSelect.Name = "cmboDeviceSelect";
            this.cmboDeviceSelect.Size = new System.Drawing.Size(245, 24);
            this.cmboDeviceSelect.TabIndex = 3;
            this.cmboDeviceSelect.ValueMember = "ID";
            // 
            // devicesTableBindingSource
            // 
            this.devicesTableBindingSource.DataMember = "Devices Table";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(875, 577);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(113, 36);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(768, 577);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(99, 36);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(263, 617);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 58);
            this.label5.TabIndex = 90;
            this.label5.Text = "*The charges displayed here are subject to change. \r\nContact your Power Service P" +
    "rovider for more information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(271, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(665, 29);
            this.label10.TabIndex = 87;
            this.label10.Text = "This will calculate the cost associated with a single device";
            // 
            // Calculator_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tblCalculator);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.BacklogoBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.clearBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                    ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calculator_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).EndInit();
            this.tblCalculator.ResumeLayout(false);
            this.tblCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Backbtn;
        private System.Windows.Forms.PictureBox BacklogoBtn;
        private System.Windows.Forms.TableLayoutPanel tblCalculator;
        private System.Windows.Forms.Label lblDailyCostDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPowerOutput;
        private System.Windows.Forms.TextBox txtHoursUsed;
        private System.Windows.Forms.Label lblYearlyCostDisplay;
        private System.Windows.Forms.Label lblMonthlyCostDisplay;
        private System.Windows.Forms.Label lblWeeklyCostDisplay;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboDeviceSelect;
       
        private System.Windows.Forms.BindingSource devicesTableBindingSource;
       
        private System.Windows.Forms.Label label10;
    }
}