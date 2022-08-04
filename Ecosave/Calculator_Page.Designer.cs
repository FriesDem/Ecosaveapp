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
            this.lblYearlyCostDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMonthlyCostDisplay = new System.Windows.Forms.Label();
            this.lblDailyCostDisplay = new System.Windows.Forms.Label();
            this.txtHoursUsed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPowerOutput = new System.Windows.Forms.TextBox();
            this.lblWeeklyCostDisplay = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfDevices = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).BeginInit();
            this.tblCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(417, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 776);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // Backbtn
            // 
            this.Backbtn.AutoSize = true;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(50, 40);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(45, 20);
            this.Backbtn.TabIndex = 79;
            this.Backbtn.Text = "Back";
            // 
            // BacklogoBtn
            // 
            this.BacklogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.BacklogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("BacklogoBtn.Image")));
            this.BacklogoBtn.Location = new System.Drawing.Point(10, 40);
            this.BacklogoBtn.Name = "BacklogoBtn";
            this.BacklogoBtn.Size = new System.Drawing.Size(40, 28);
            this.BacklogoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BacklogoBtn.TabIndex = 78;
            this.BacklogoBtn.TabStop = false;
            // 
            // tblCalculator
            // 
            this.tblCalculator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCalculator.ColumnCount = 3;
            this.tblCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.92517F));
            this.tblCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.91156F));
            this.tblCalculator.Controls.Add(this.label7, 0, 5);
            this.tblCalculator.Controls.Add(this.label8, 0, 6);
            this.tblCalculator.Controls.Add(this.label9, 0, 7);
            this.tblCalculator.Controls.Add(this.label3, 0, 1);
            this.tblCalculator.Controls.Add(this.label4, 0, 2);
            this.tblCalculator.Controls.Add(this.txtHoursUsed, 1, 2);
            this.tblCalculator.Controls.Add(this.label6, 0, 4);
            this.tblCalculator.Controls.Add(this.lblWeeklyCostDisplay, 1, 5);
            this.tblCalculator.Controls.Add(this.clearBtn, 2, 3);
            this.tblCalculator.Controls.Add(this.calculateBtn, 0, 3);
            this.tblCalculator.Controls.Add(this.lblDailyCostDisplay, 1, 4);
            this.tblCalculator.Controls.Add(this.lblYearlyCostDisplay, 1, 7);
            this.tblCalculator.Controls.Add(this.lblMonthlyCostDisplay, 1, 6);
            this.tblCalculator.Controls.Add(this.txtPowerOutput, 1, 1);
            this.tblCalculator.Controls.Add(this.label1, 0, 0);
            this.tblCalculator.Controls.Add(this.numberOfDevices, 1, 0);
            this.tblCalculator.Location = new System.Drawing.Point(201, 119);
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
            this.tblCalculator.Size = new System.Drawing.Size(715, 344);
            this.tblCalculator.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(3, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weekly Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(3, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Monthly Cost";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(3, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yearly Cost";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Power Output";
            // 
            // lblYearlyCostDisplay
            // 
            this.lblYearlyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblYearlyCostDisplay.Location = new System.Drawing.Point(240, 301);
            this.lblYearlyCostDisplay.Name = "lblYearlyCostDisplay";
            this.lblYearlyCostDisplay.Size = new System.Drawing.Size(263, 32);
            this.lblYearlyCostDisplay.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hours Used (kWh)";
            // 
            // lblMonthlyCostDisplay
            // 
            this.lblMonthlyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMonthlyCostDisplay.Location = new System.Drawing.Point(240, 258);
            this.lblMonthlyCostDisplay.Name = "lblMonthlyCostDisplay";
            this.lblMonthlyCostDisplay.Size = new System.Drawing.Size(263, 32);
            this.lblMonthlyCostDisplay.TabIndex = 0;
            // 
            // lblDailyCostDisplay
            // 
            this.lblDailyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDailyCostDisplay.Location = new System.Drawing.Point(240, 172);
            this.lblDailyCostDisplay.Name = "lblDailyCostDisplay";
            this.lblDailyCostDisplay.Size = new System.Drawing.Size(263, 32);
            this.lblDailyCostDisplay.TabIndex = 0;
            // 
            // txtHoursUsed
            // 
            this.txtHoursUsed.Location = new System.Drawing.Point(240, 89);
            this.txtHoursUsed.Name = "txtHoursUsed";
            this.txtHoursUsed.Size = new System.Drawing.Size(106, 20);
            this.txtHoursUsed.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(3, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Daily Cost";
            // 
            // txtPowerOutput
            // 
            this.txtPowerOutput.Location = new System.Drawing.Point(240, 46);
            this.txtPowerOutput.Name = "txtPowerOutput";
            this.txtPowerOutput.Size = new System.Drawing.Size(103, 20);
            this.txtPowerOutput.TabIndex = 2;
            // 
            // lblWeeklyCostDisplay
            // 
            this.lblWeeklyCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWeeklyCostDisplay.Location = new System.Drawing.Point(240, 215);
            this.lblWeeklyCostDisplay.Name = "lblWeeklyCostDisplay";
            this.lblWeeklyCostDisplay.Size = new System.Drawing.Size(263, 32);
            this.lblWeeklyCostDisplay.TabIndex = 0;
            // 
            // calculateBtn
            // 
            this.tblCalculator.SetColumnSpan(this.calculateBtn, 2);
            this.calculateBtn.Location = new System.Drawing.Point(3, 132);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(74, 29);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(510, 132);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 29);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Devices";
            // 
            // numberOfDevices
            // 
            this.numberOfDevices.Location = new System.Drawing.Point(240, 3);
            this.numberOfDevices.Name = "numberOfDevices";
            this.numberOfDevices.Size = new System.Drawing.Size(120, 20);
            this.numberOfDevices.TabIndex = 4;
            // 
            // Calculator_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1054, 643);
            this.Controls.Add(this.tblCalculator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.BacklogoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculator_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).EndInit();
            this.tblCalculator.ResumeLayout(false);
            this.tblCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDevices)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numberOfDevices;
    }
}