namespace Ecosave
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Title1 = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.EmailTB1 = new System.Windows.Forms.TextBox();
            this.PasswordTB2 = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.FPass = new System.Windows.Forms.Label();
            this.DHAALbl = new System.Windows.Forms.Label();
            this.CAABtn = new System.Windows.Forms.Label();
            this.SigninBtn = new System.Windows.Forms.Button();
            this.reveal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reveal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Emaillabel.Location = new System.Drawing.Point(434, 379);
            this.Emaillabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(60, 25);
            this.Emaillabel.TabIndex = 1;
            this.Emaillabel.Text = "Email";
            this.Emaillabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Passwordlabel.Location = new System.Drawing.Point(434, 495);
            this.Passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(98, 25);
            this.Passwordlabel.TabIndex = 2;
            this.Passwordlabel.Text = "Password";
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.BackColor = System.Drawing.Color.Transparent;
            this.Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title1.Location = new System.Drawing.Point(575, 290);
            this.Title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(163, 69);
            this.Title1.TabIndex = 3;
            this.Title1.Text = "ECO";
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.BackColor = System.Drawing.Color.Transparent;
            this.Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title2.Location = new System.Drawing.Point(746, 290);
            this.Title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(170, 69);
            this.Title2.TabIndex = 4;
            this.Title2.Text = "Save";
            this.Title2.Click += new System.EventHandler(this.Title2_Click);
            // 
            // EmailTB1
            // 
            this.EmailTB1.BackColor = System.Drawing.Color.SteelBlue;
            this.EmailTB1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailTB1.Location = new System.Drawing.Point(439, 420);
            this.EmailTB1.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTB1.Name = "EmailTB1";
            this.EmailTB1.Size = new System.Drawing.Size(641, 30);
            this.EmailTB1.TabIndex = 5;
            // 
            // PasswordTB2
            // 
            this.PasswordTB2.BackColor = System.Drawing.Color.SteelBlue;
            this.PasswordTB2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasswordTB2.Location = new System.Drawing.Point(439, 538);
            this.PasswordTB2.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTB2.Name = "PasswordTB2";
            this.PasswordTB2.PasswordChar = '*';
            this.PasswordTB2.Size = new System.Drawing.Size(641, 30);
            this.PasswordTB2.TabIndex = 6;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(1451, 9);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(24, 24);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FPass
            // 
            this.FPass.AutoSize = true;
            this.FPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FPass.Location = new System.Drawing.Point(665, 637);
            this.FPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FPass.Name = "FPass";
            this.FPass.Size = new System.Drawing.Size(159, 25);
            this.FPass.TabIndex = 9;
            this.FPass.Text = "Forgot Password";
            this.FPass.Click += new System.EventHandler(this.FPass_Click);
            // 
            // DHAALbl
            // 
            this.DHAALbl.AutoSize = true;
            this.DHAALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DHAALbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DHAALbl.Location = new System.Drawing.Point(639, 686);
            this.DHAALbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DHAALbl.Name = "DHAALbl";
            this.DHAALbl.Size = new System.Drawing.Size(213, 25);
            this.DHAALbl.TabIndex = 10;
            this.DHAALbl.Text = "Dont have an account?";
            // 
            // CAABtn
            // 
            this.CAABtn.AutoSize = true;
            this.CAABtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAABtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CAABtn.Location = new System.Drawing.Point(666, 726);
            this.CAABtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CAABtn.Name = "CAABtn";
            this.CAABtn.Size = new System.Drawing.Size(146, 20);
            this.CAABtn.TabIndex = 11;
            this.CAABtn.Text = "Create an account";
            this.CAABtn.Click += new System.EventHandler(this.CAABtn_Click);
            // 
            // SigninBtn
            // 
            this.SigninBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninBtn.Location = new System.Drawing.Point(693, 583);
            this.SigninBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(100, 28);
            this.SigninBtn.TabIndex = 17;
            this.SigninBtn.Text = "Sign In";
            this.SigninBtn.UseVisualStyleBackColor = true;
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // reveal
            // 
            this.reveal.Image = ((System.Drawing.Image)(resources.GetObject("reveal.Image")));
            this.reveal.Location = new System.Drawing.Point(1042, 575);
            this.reveal.Name = "reveal";
            this.reveal.Size = new System.Drawing.Size(38, 17);
            this.reveal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reveal.TabIndex = 18;
            this.reveal.TabStop = false;
            this.reveal.Click += new System.EventHandler(this.reveal_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1488, 829);
            this.Controls.Add(this.reveal);
            this.Controls.Add(this.SigninBtn);
            this.Controls.Add(this.CAABtn);
            this.Controls.Add(this.DHAALbl);
            this.Controls.Add(this.FPass);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PasswordTB2);
            this.Controls.Add(this.EmailTB1);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reveal)).EndInit();
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
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label FPass;
        private System.Windows.Forms.Label DHAALbl;
        private System.Windows.Forms.Label CAABtn;
        private System.Windows.Forms.Button SigninBtn;
        private System.Windows.Forms.PictureBox reveal;
    }
}

