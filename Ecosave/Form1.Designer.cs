namespace Ecosave
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Title1 = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.EmailTB1 = new System.Windows.Forms.TextBox();
            this.PasswordTB2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(167, 393);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(53, 28);
            this.Emaillabel.TabIndex = 1;
            this.Emaillabel.Text = "Email";
            this.Emaillabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.Location = new System.Drawing.Point(167, 462);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(88, 28);
            this.Passwordlabel.TabIndex = 2;
            this.Passwordlabel.Text = "Password";
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.BackColor = System.Drawing.Color.Transparent;
            this.Title1.Font = new System.Drawing.Font("Aquire", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title1.Location = new System.Drawing.Point(412, 258);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(124, 48);
            this.Title1.TabIndex = 3;
            this.Title1.Text = "ECO";
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.BackColor = System.Drawing.Color.Transparent;
            this.Title2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title2.Font = new System.Drawing.Font("Poppins SemiBold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title2.Location = new System.Drawing.Point(529, 252);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(154, 84);
            this.Title2.TabIndex = 4;
            this.Title2.Text = "Save";
            // 
            // EmailTB1
            // 
            this.EmailTB1.BackColor = System.Drawing.Color.SteelBlue;
            this.EmailTB1.Location = new System.Drawing.Point(258, 401);
            this.EmailTB1.Name = "EmailTB1";
            this.EmailTB1.Size = new System.Drawing.Size(492, 20);
            this.EmailTB1.TabIndex = 5;
            // 
            // PasswordTB2
            // 
            this.PasswordTB2.BackColor = System.Drawing.Color.SteelBlue;
            this.PasswordTB2.Location = new System.Drawing.Point(258, 466);
            this.PasswordTB2.Name = "PasswordTB2";
            this.PasswordTB2.Size = new System.Drawing.Size(492, 20);
            this.PasswordTB2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.PasswordTB2);
            this.Controls.Add(this.EmailTB1);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.TextBox EmailTB1;
        private System.Windows.Forms.TextBox PasswordTB2;
    }
}

