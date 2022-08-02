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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tempValueLabel = new System.Windows.Forms.Label();
            this.numDevicesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfDevices = new System.Windows.Forms.NumericUpDown();
            this.calculatorDisplay = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Label();
            this.BacklogoBtn = new System.Windows.Forms.PictureBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.deimalBtn = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1261, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 955);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // tempValueLabel
            // 
            this.tempValueLabel.AutoSize = true;
            this.tempValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tempValueLabel.Location = new System.Drawing.Point(734, 264);
            this.tempValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempValueLabel.Name = "tempValueLabel";
            this.tempValueLabel.Size = new System.Drawing.Size(0, 36);
            this.tempValueLabel.TabIndex = 60;
            this.tempValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDevicesBtn
            // 
            this.numDevicesBtn.Location = new System.Drawing.Point(462, 347);
            this.numDevicesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.numDevicesBtn.Name = "numDevicesBtn";
            this.numDevicesBtn.Size = new System.Drawing.Size(141, 48);
            this.numDevicesBtn.TabIndex = 59;
            this.numDevicesBtn.Text = "SUBMIT";
            this.numDevicesBtn.UseVisualStyleBackColor = true;
            this.numDevicesBtn.Click += new System.EventHandler(this.numDevicesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(209, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Number of Devices";
            // 
            // numberOfDevices
            // 
            this.numberOfDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numberOfDevices.Location = new System.Drawing.Point(453, 303);
            this.numberOfDevices.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfDevices.Name = "numberOfDevices";
            this.numberOfDevices.Size = new System.Drawing.Size(160, 36);
            this.numberOfDevices.TabIndex = 57;
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.calculatorDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.calculatorDisplay.Location = new System.Drawing.Point(731, 303);
            this.calculatorDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.calculatorDisplay.Multiline = true;
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.ReadOnly = true;
            this.calculatorDisplay.Size = new System.Drawing.Size(311, 78);
            this.calculatorDisplay.TabIndex = 56;
            this.calculatorDisplay.Text = "0";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(830, 721);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(133, 43);
            this.submitBtn.TabIndex = 55;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
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
            this.Backbtn.TabIndex = 54;
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
            this.BacklogoBtn.TabIndex = 53;
            this.BacklogoBtn.TabStop = false;
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.plusBtn.Location = new System.Drawing.Point(971, 389);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(72, 121);
            this.plusBtn.TabIndex = 51;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.arithmeticBtn);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.multiplyBtn.Location = new System.Drawing.Point(971, 517);
            this.multiplyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(72, 121);
            this.multiplyBtn.TabIndex = 50;
            this.multiplyBtn.Text = "x";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.arithmeticBtn);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.clearBtn.Location = new System.Drawing.Point(731, 389);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(232, 57);
            this.clearBtn.TabIndex = 38;
            this.clearBtn.Text = "AC";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.equalBtn.Location = new System.Drawing.Point(891, 645);
            this.equalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(152, 57);
            this.equalBtn.TabIndex = 48;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num3.Location = new System.Drawing.Point(891, 581);
            this.num3.Margin = new System.Windows.Forms.Padding(4);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(72, 57);
            this.num3.TabIndex = 47;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num0_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num6.Location = new System.Drawing.Point(891, 517);
            this.num6.Margin = new System.Windows.Forms.Padding(4);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(72, 57);
            this.num6.TabIndex = 46;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num0_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num9.Location = new System.Drawing.Point(891, 453);
            this.num9.Margin = new System.Windows.Forms.Padding(4);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(72, 57);
            this.num9.TabIndex = 45;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num0_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num0.Location = new System.Drawing.Point(731, 645);
            this.num0.Margin = new System.Windows.Forms.Padding(4);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(72, 57);
            this.num0.TabIndex = 44;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // deimalBtn
            // 
            this.deimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deimalBtn.Location = new System.Drawing.Point(811, 645);
            this.deimalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deimalBtn.Name = "deimalBtn";
            this.deimalBtn.Size = new System.Drawing.Size(72, 57);
            this.deimalBtn.TabIndex = 43;
            this.deimalBtn.Text = ".";
            this.deimalBtn.UseVisualStyleBackColor = true;
            this.deimalBtn.Click += new System.EventHandler(this.num0_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num2.Location = new System.Drawing.Point(811, 581);
            this.num2.Margin = new System.Windows.Forms.Padding(4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(72, 57);
            this.num2.TabIndex = 42;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num0_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num5.Location = new System.Drawing.Point(811, 517);
            this.num5.Margin = new System.Windows.Forms.Padding(4);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(72, 57);
            this.num5.TabIndex = 41;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num0_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num8.Location = new System.Drawing.Point(811, 453);
            this.num8.Margin = new System.Windows.Forms.Padding(4);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(72, 57);
            this.num8.TabIndex = 40;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num0_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num1.Location = new System.Drawing.Point(731, 581);
            this.num1.Margin = new System.Windows.Forms.Padding(4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(72, 57);
            this.num1.TabIndex = 39;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num0_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num4.Location = new System.Drawing.Point(731, 517);
            this.num4.Margin = new System.Windows.Forms.Padding(4);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(72, 57);
            this.num4.TabIndex = 52;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num0_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num7.Location = new System.Drawing.Point(731, 453);
            this.num7.Margin = new System.Windows.Forms.Padding(4);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(72, 57);
            this.num7.TabIndex = 49;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num0_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(756, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Calculator";
            // 
            // Calculator_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tempValueLabel);
            this.Controls.Add(this.numDevicesBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfDevices);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.BacklogoBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.deimalBtn);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculator_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calculator_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tempValueLabel;
        private System.Windows.Forms.Button numDevicesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfDevices;
        private System.Windows.Forms.TextBox calculatorDisplay;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label Backbtn;
        private System.Windows.Forms.PictureBox BacklogoBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button deimalBtn;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Label label2;
    }
}