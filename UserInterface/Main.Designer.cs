using MetroFramework.Controls;

namespace UserInterface
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.leftlogo = new System.Windows.Forms.Panel();
            this.LoginBox = new System.Windows.Forms.Panel();
            this.adminloginboxbutton = new MetroFramework.Controls.MetroButton();
            this.employeloginboxbutton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftlogo
            // 
            this.leftlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftlogo.BackgroundImage")));
            this.leftlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftlogo.Location = new System.Drawing.Point(2, 6);
            this.leftlogo.Name = "leftlogo";
            this.leftlogo.Size = new System.Drawing.Size(158, 130);
            this.leftlogo.TabIndex = 0;
            this.leftlogo.Visible = false;
            // 
            // LoginBox
            // 
            this.LoginBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBox.BackgroundImage")));
            this.LoginBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBox.Location = new System.Drawing.Point(206, 48);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(397, 168);
            this.LoginBox.TabIndex = 1;
            // 
            // adminloginboxbutton
            // 
            this.adminloginboxbutton.Location = new System.Drawing.Point(158, 277);
            this.adminloginboxbutton.Name = "adminloginboxbutton";
            this.adminloginboxbutton.Size = new System.Drawing.Size(88, 23);
            this.adminloginboxbutton.TabIndex = 2;
            this.adminloginboxbutton.Text = "Admin Login";
            this.adminloginboxbutton.Click += new System.EventHandler(this.adminloginbox_Click);
            // 
            // employeloginboxbutton
            // 
            this.employeloginboxbutton.Location = new System.Drawing.Point(507, 277);
            this.employeloginboxbutton.Name = "employeloginboxbutton";
            this.employeloginboxbutton.Size = new System.Drawing.Size(96, 23);
            this.employeloginboxbutton.TabIndex = 3;
            this.employeloginboxbutton.Text = "Employee Login";
            this.employeloginboxbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(560, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Build Version 1.0.0.0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeloginboxbutton);
            this.Controls.Add(this.adminloginboxbutton);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.leftlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "SFdev HRMS";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftlogo;
        private System.Windows.Forms.Panel LoginBox;
        private MetroFramework.Controls.MetroButton adminloginboxbutton;
        private MetroFramework.Controls.MetroButton employeloginboxbutton;
        private System.Windows.Forms.Label label1;
        
    }
}

