namespace Ecosave
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.CalculatorBtn = new System.Windows.Forms.Button();
            this.TipsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.manageUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.storeToolStripMenuItem.Text = "Store";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NavPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(961, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(477, 868);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(961, 175);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // NavPanel
            // 
            this.NavPanel.AutoSize = true;
            this.NavPanel.BackColor = System.Drawing.Color.LightCyan;
            this.NavPanel.Controls.Add(this.pictureBox2);
            this.NavPanel.Controls.Add(this.ProfileBtn);
            this.NavPanel.Controls.Add(this.CalculatorBtn);
            this.NavPanel.Controls.Add(this.TipsBtn);
            this.NavPanel.Controls.Add(this.HomeBtn);
            this.NavPanel.Location = new System.Drawing.Point(23, 32);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(4);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(913, 78);
            this.NavPanel.TabIndex = 41;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(829, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileBtn.BackgroundImage")));
            this.ProfileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Location = new System.Drawing.Point(645, 14);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(103, 60);
            this.ProfileBtn.TabIndex = 3;
            this.ProfileBtn.UseVisualStyleBackColor = true;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // CalculatorBtn
            // 
            this.CalculatorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CalculatorBtn.BackgroundImage")));
            this.CalculatorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CalculatorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatorBtn.Location = new System.Drawing.Point(449, 14);
            this.CalculatorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CalculatorBtn.Name = "CalculatorBtn";
            this.CalculatorBtn.Size = new System.Drawing.Size(103, 60);
            this.CalculatorBtn.TabIndex = 2;
            this.CalculatorBtn.UseVisualStyleBackColor = true;
            this.CalculatorBtn.Click += new System.EventHandler(this.CalculatorBtn_Click);
            // 
            // TipsBtn
            // 
            this.TipsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TipsBtn.BackgroundImage")));
            this.TipsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TipsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipsBtn.Location = new System.Drawing.Point(275, 14);
            this.TipsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TipsBtn.Name = "TipsBtn";
            this.TipsBtn.Size = new System.Drawing.Size(103, 60);
            this.TipsBtn.TabIndex = 1;
            this.TipsBtn.UseVisualStyleBackColor = true;
            this.TipsBtn.Click += new System.EventHandler(this.TipsBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Location = new System.Drawing.Point(97, 14);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(103, 60);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eco Save";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.NavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Button CalculatorBtn;
        private System.Windows.Forms.Button TipsBtn;
        private System.Windows.Forms.Button HomeBtn;
    }
}