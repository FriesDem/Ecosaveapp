namespace Ecosave
{
    partial class manageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageUsers));
            this.Backbtn = new System.Windows.Forms.Label();
            this.BacklogoBtn = new System.Windows.Forms.PictureBox();
            this.CreateanLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.manageuser = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.AutoSize = true;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(79, 65);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(56, 25);
            this.Backbtn.TabIndex = 22;
            this.Backbtn.Text = "Back";
            // 
            // BacklogoBtn
            // 
            this.BacklogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.BacklogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("BacklogoBtn.Image")));
            this.BacklogoBtn.Location = new System.Drawing.Point(13, 57);
            this.BacklogoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BacklogoBtn.Name = "BacklogoBtn";
            this.BacklogoBtn.Size = new System.Drawing.Size(53, 34);
            this.BacklogoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BacklogoBtn.TabIndex = 21;
            this.BacklogoBtn.TabStop = false;
            this.BacklogoBtn.Click += new System.EventHandler(this.BacklogoBtn_Click);
            // 
            // CreateanLbl
            // 
            this.CreateanLbl.AutoSize = true;
            this.CreateanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateanLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateanLbl.Location = new System.Drawing.Point(822, 87);
            this.CreateanLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateanLbl.Name = "CreateanLbl";
            this.CreateanLbl.Size = new System.Drawing.Size(234, 38);
            this.CreateanLbl.TabIndex = 23;
            this.CreateanLbl.Text = "Manage User ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Please ensure to review all changes before saving, deleting ,changing a persons s" +
    "tatus";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(105, 265);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 30);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(105, 389);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(99, 29);
            this.btnAddUser.TabIndex = 26;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(105, 527);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(155, 31);
            this.btnResetPassword.TabIndex = 27;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateUser.Location = new System.Drawing.Point(106, 677);
            this.btnDeactivateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(259, 32);
            this.btnDeactivateUser.TabIndex = 28;
            this.btnDeactivateUser.Text = "Deactivate User / Activate";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // manageuser
            // 
            this.manageuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manageuser.BackgroundColor = System.Drawing.Color.SlateGray;
            this.manageuser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manageuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageuser.GridColor = System.Drawing.Color.SteelBlue;
            this.manageuser.Location = new System.Drawing.Point(371, 265);
            this.manageuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageuser.Name = "manageuser";
            this.manageuser.RowHeadersWidth = 51;
            this.manageuser.RowTemplate.Height = 24;
            this.manageuser.Size = new System.Drawing.Size(1341, 444);
            this.manageuser.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1453, -105);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(742, 479);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // manageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.manageuser);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateanLbl);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.BacklogoBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "manageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageUserscs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.manageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Backbtn;
        private System.Windows.Forms.PictureBox BacklogoBtn;
        private System.Windows.Forms.Label CreateanLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.DataGridView manageuser;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}