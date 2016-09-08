using MetroFramework.Controls;

namespace UserInterface
{
    partial class employeelogin
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
            this.employeeid = new MetroFramework.Controls.MetroTextBox();
            this.employeepassword = new MetroFramework.Controls.MetroTextBox();
            this.employeeloginbutton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // employeeid
            // 
            this.employeeid.Location = new System.Drawing.Point(122, 22);
            this.employeeid.Name = "employeeid";
            this.employeeid.Size = new System.Drawing.Size(239, 27);
            this.employeeid.TabIndex = 2;
            // 
            // employeepassword
            // 
            this.employeepassword.Location = new System.Drawing.Point(122, 67);
            this.employeepassword.Name = "employeepassword";
            this.employeepassword.PasswordChar = '●';
            this.employeepassword.Size = new System.Drawing.Size(239, 27);
            this.employeepassword.TabIndex = 3;
            this.employeepassword.UseSystemPasswordChar = true;
            this.employeepassword.TextChanged += new System.EventHandler(this.employeepassword_TextChanged);
            // 
            // employeeloginbutton
            // 
            this.employeeloginbutton.Location = new System.Drawing.Point(263, 116);
            this.employeeloginbutton.Name = "employeeloginbutton";
            this.employeeloginbutton.Size = new System.Drawing.Size(98, 29);
            this.employeeloginbutton.TabIndex = 4;
            this.employeeloginbutton.Text = "Login";
            this.employeeloginbutton.Click += new System.EventHandler(this.employeeloginbutton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(13, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "User name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(25, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password";
            // 
            // employeelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.employeeloginbutton);
            this.Controls.Add(this.employeepassword);
            this.Controls.Add(this.employeeid);
            this.Name = "employeelogin";
            this.Size = new System.Drawing.Size(397, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroTextBox employeeid;
        private MetroTextBox employeepassword;
        private MetroButton employeeloginbutton;
        private MetroLabel metroLabel1;
        private MetroLabel metroLabel2;
    }
}
