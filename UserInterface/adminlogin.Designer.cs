using MetroFramework.Controls;

namespace UserInterface
{
    partial class adminlogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminid = new MetroFramework.Controls.MetroTextBox();
            this.adminpassword = new MetroFramework.Controls.MetroTextBox();
            this.adminloginbutton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // adminid
            // 
            this.adminid.Location = new System.Drawing.Point(127, 32);
            this.adminid.Name = "adminid";
            this.adminid.Size = new System.Drawing.Size(239, 27);
            this.adminid.TabIndex = 2;
            this.adminid.TextChanged += new System.EventHandler(this.adminid_TextChanged);
            // 
            // adminpassword
            // 
            this.adminpassword.Location = new System.Drawing.Point(127, 77);
            this.adminpassword.Name = "adminpassword";
            this.adminpassword.PasswordChar = '●';
            this.adminpassword.Size = new System.Drawing.Size(239, 27);
            this.adminpassword.TabIndex = 3;
            this.adminpassword.UseSystemPasswordChar = true;
            this.adminpassword.TextChanged += new System.EventHandler(this.adminpassword_TextChanged);
            // 
            // adminloginbutton
            // 
            this.adminloginbutton.Location = new System.Drawing.Point(291, 120);
            this.adminloginbutton.Name = "adminloginbutton";
            this.adminloginbutton.Size = new System.Drawing.Size(75, 23);
            this.adminloginbutton.TabIndex = 4;
            this.adminloginbutton.Text = "Login";
            this.adminloginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(24, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "User name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(39, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password";
            // 
            // adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.adminloginbutton);
            this.Controls.Add(this.adminpassword);
            this.Controls.Add(this.adminid);
            this.Name = "adminlogin";
            this.Size = new System.Drawing.Size(397, 168);
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroTextBox adminid;
        private MetroTextBox adminpassword;
        private MetroFramework.Controls.MetroButton adminloginbutton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
