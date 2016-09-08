using MetroFramework.Controls;

namespace UserInterface.AdminManage
{
    partial class AddNewAdmin
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
            this.adminidadd = new System.Windows.Forms.Label();
            this.adminidaddtext = new MetroFramework.Controls.MetroTextBox();
            this.adminnameadd = new MetroFramework.Controls.MetroLabel();
            this.adminnametext = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.adminpasswordtext = new MetroFramework.Controls.MetroTextBox();
            this.buttonadmininsert = new MetroFramework.Controls.MetroButton();
            this.clearadminadd = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // adminidadd
            // 
            this.adminidadd.AutoSize = true;
            this.adminidadd.Location = new System.Drawing.Point(92, 60);
            this.adminidadd.Name = "adminidadd";
            this.adminidadd.Size = new System.Drawing.Size(50, 13);
            this.adminidadd.TabIndex = 0;
            this.adminidadd.Text = "Admin ID";
            // 
            // adminidaddtext
            // 
            // 
            // 
            // 
            this.adminidaddtext.CustomButton.Image = null;
            this.adminidaddtext.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.adminidaddtext.CustomButton.Name = "";
            this.adminidaddtext.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.adminidaddtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminidaddtext.CustomButton.TabIndex = 1;
            this.adminidaddtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminidaddtext.CustomButton.UseSelectable = true;
            this.adminidaddtext.CustomButton.Visible = false;
            this.adminidaddtext.Lines = new string[0];
            this.adminidaddtext.Location = new System.Drawing.Point(161, 60);
            this.adminidaddtext.MaxLength = 32767;
            this.adminidaddtext.Name = "adminidaddtext";
            this.adminidaddtext.PasswordChar = '\0';
            this.adminidaddtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminidaddtext.SelectedText = "";
            this.adminidaddtext.SelectionLength = 0;
            this.adminidaddtext.SelectionStart = 0;
            this.adminidaddtext.ShortcutsEnabled = true;
            this.adminidaddtext.Size = new System.Drawing.Size(284, 31);
            this.adminidaddtext.TabIndex = 0;
            this.adminidaddtext.UseSelectable = true;
            this.adminidaddtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminidaddtext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // adminnameadd
            // 
            this.adminnameadd.AutoSize = true;
            this.adminnameadd.Location = new System.Drawing.Point(54, 97);
            this.adminnameadd.Name = "adminnameadd";
            this.adminnameadd.Size = new System.Drawing.Size(88, 19);
            this.adminnameadd.TabIndex = 1;
            this.adminnameadd.Text = "Admin Name";
            // 
            // adminnametext
            // 
            // 
            // 
            // 
            this.adminnametext.CustomButton.Image = null;
            this.adminnametext.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.adminnametext.CustomButton.Name = "";
            this.adminnametext.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.adminnametext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminnametext.CustomButton.TabIndex = 1;
            this.adminnametext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminnametext.CustomButton.UseSelectable = true;
            this.adminnametext.CustomButton.Visible = false;
            this.adminnametext.Lines = new string[0];
            this.adminnametext.Location = new System.Drawing.Point(161, 97);
            this.adminnametext.MaxLength = 32767;
            this.adminnametext.Name = "adminnametext";
            this.adminnametext.PasswordChar = '\0';
            this.adminnametext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminnametext.SelectedText = "";
            this.adminnametext.SelectionLength = 0;
            this.adminnametext.SelectionStart = 0;
            this.adminnametext.ShortcutsEnabled = true;
            this.adminnametext.Size = new System.Drawing.Size(284, 31);
            this.adminnametext.TabIndex = 1;
            this.adminnametext.UseSelectable = true;
            this.adminnametext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminnametext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Password";
            // 
            // adminpasswordtext
            // 
            // 
            // 
            // 
            this.adminpasswordtext.CustomButton.Image = null;
            this.adminpasswordtext.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.adminpasswordtext.CustomButton.Name = "";
            this.adminpasswordtext.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.adminpasswordtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminpasswordtext.CustomButton.TabIndex = 1;
            this.adminpasswordtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminpasswordtext.CustomButton.UseSelectable = true;
            this.adminpasswordtext.CustomButton.Visible = false;
            this.adminpasswordtext.Lines = new string[0];
            this.adminpasswordtext.Location = new System.Drawing.Point(161, 134);
            this.adminpasswordtext.MaxLength = 32767;
            this.adminpasswordtext.Name = "adminpasswordtext";
            this.adminpasswordtext.PasswordChar = '\0';
            this.adminpasswordtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminpasswordtext.SelectedText = "";
            this.adminpasswordtext.SelectionLength = 0;
            this.adminpasswordtext.SelectionStart = 0;
            this.adminpasswordtext.ShortcutsEnabled = true;
            this.adminpasswordtext.Size = new System.Drawing.Size(284, 31);
            this.adminpasswordtext.TabIndex = 2;
            this.adminpasswordtext.UseSelectable = true;
            this.adminpasswordtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminpasswordtext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonadmininsert
            // 
            this.buttonadmininsert.Location = new System.Drawing.Point(354, 171);
            this.buttonadmininsert.Name = "buttonadmininsert";
            this.buttonadmininsert.Size = new System.Drawing.Size(91, 31);
            this.buttonadmininsert.TabIndex = 3;
            this.buttonadmininsert.Text = "Save";
            this.buttonadmininsert.UseSelectable = true;
            this.buttonadmininsert.Click += new System.EventHandler(this.buttonadmininsert_Click);
            // 
            // clearadminadd
            // 
            this.clearadminadd.Location = new System.Drawing.Point(245, 171);
            this.clearadminadd.Name = "clearadminadd";
            this.clearadminadd.Size = new System.Drawing.Size(91, 31);
            this.clearadminadd.TabIndex = 4;
            this.clearadminadd.Text = "Clear";
            this.clearadminadd.UseSelectable = true;
            this.clearadminadd.Click += new System.EventHandler(this.clearadminadd_Click);
            // 
            // AddNewAdmin
            // 
            this.AcceptButton = this.clearadminadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(486, 221);
            this.Controls.Add(this.clearadminadd);
            this.Controls.Add(this.buttonadmininsert);
            this.Controls.Add(this.adminpasswordtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminnametext);
            this.Controls.Add(this.adminnameadd);
            this.Controls.Add(this.adminidaddtext);
            this.Controls.Add(this.adminidadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddNewAdmin";
            this.Resizable = false;
            this.Text = "Add New Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminidadd;
        private MetroTextBox adminidaddtext;
        private MetroLabel adminnameadd;
        private MetroTextBox adminnametext;
        private MetroLabel label1;
        private MetroTextBox adminpasswordtext;
        private MetroButton buttonadmininsert;
        private MetroButton clearadminadd;
    }
}