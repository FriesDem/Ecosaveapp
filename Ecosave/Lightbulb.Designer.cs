﻿namespace Ecosave
{
    partial class Lightbulb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lightbulb));
            this.Backbtn = new System.Windows.Forms.Label();
            this.BacklogoBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.AutoSize = true;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backbtn.Location = new System.Drawing.Point(69, 21);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(56, 25);
            this.Backbtn.TabIndex = 42;
            this.Backbtn.Text = "Back";
            // 
            // BacklogoBtn
            // 
            this.BacklogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.BacklogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("BacklogoBtn.Image")));
            this.BacklogoBtn.Location = new System.Drawing.Point(13, 13);
            this.BacklogoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BacklogoBtn.Name = "BacklogoBtn";
            this.BacklogoBtn.Size = new System.Drawing.Size(53, 34);
            this.BacklogoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BacklogoBtn.TabIndex = 43;
            this.BacklogoBtn.TabStop = false;
            // 
            // Lightbulb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1906, 1055);
            this.Controls.Add(this.BacklogoBtn);
            this.Controls.Add(this.Backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lightbulb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lightbulb";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BacklogoBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Backbtn;
        private System.Windows.Forms.PictureBox BacklogoBtn;
    }
}