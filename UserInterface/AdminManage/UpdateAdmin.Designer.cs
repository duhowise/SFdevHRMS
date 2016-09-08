using MetroFramework.Controls;

namespace UserInterface.AdminManage
{
    partial class UpdateAdmin
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
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.updateadminnametext = new MetroFramework.Controls.MetroTextBox();
            this.updateadminpasswordtext = new MetroFramework.Controls.MetroTextBox();
            this.updateadminsave = new MetroFramework.Controls.MetroButton();
            this.updateadminidcombobox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Password";
            // 
            // updateadminnametext
            // 
            // 
            // 
            // 
            this.updateadminnametext.CustomButton.Image = null;
            this.updateadminnametext.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.updateadminnametext.CustomButton.Name = "";
            this.updateadminnametext.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.updateadminnametext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.updateadminnametext.CustomButton.TabIndex = 1;
            this.updateadminnametext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateadminnametext.CustomButton.UseSelectable = true;
            this.updateadminnametext.CustomButton.Visible = false;
            this.updateadminnametext.Lines = new string[0];
            this.updateadminnametext.Location = new System.Drawing.Point(170, 116);
            this.updateadminnametext.MaxLength = 32767;
            this.updateadminnametext.Name = "updateadminnametext";
            this.updateadminnametext.PasswordChar = '\0';
            this.updateadminnametext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.updateadminnametext.SelectedText = "";
            this.updateadminnametext.SelectionLength = 0;
            this.updateadminnametext.SelectionStart = 0;
            this.updateadminnametext.ShortcutsEnabled = true;
            this.updateadminnametext.Size = new System.Drawing.Size(196, 31);
            this.updateadminnametext.TabIndex = 4;
            this.updateadminnametext.UseSelectable = true;
            this.updateadminnametext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.updateadminnametext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // updateadminpasswordtext
            // 
            // 
            // 
            // 
            this.updateadminpasswordtext.CustomButton.Image = null;
            this.updateadminpasswordtext.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.updateadminpasswordtext.CustomButton.Name = "";
            this.updateadminpasswordtext.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.updateadminpasswordtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.updateadminpasswordtext.CustomButton.TabIndex = 1;
            this.updateadminpasswordtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateadminpasswordtext.CustomButton.UseSelectable = true;
            this.updateadminpasswordtext.CustomButton.Visible = false;
            this.updateadminpasswordtext.Lines = new string[0];
            this.updateadminpasswordtext.Location = new System.Drawing.Point(170, 158);
            this.updateadminpasswordtext.MaxLength = 32767;
            this.updateadminpasswordtext.Name = "updateadminpasswordtext";
            this.updateadminpasswordtext.PasswordChar = '\0';
            this.updateadminpasswordtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.updateadminpasswordtext.SelectedText = "";
            this.updateadminpasswordtext.SelectionLength = 0;
            this.updateadminpasswordtext.SelectionStart = 0;
            this.updateadminpasswordtext.ShortcutsEnabled = true;
            this.updateadminpasswordtext.Size = new System.Drawing.Size(196, 31);
            this.updateadminpasswordtext.TabIndex = 5;
            this.updateadminpasswordtext.UseSelectable = true;
            this.updateadminpasswordtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.updateadminpasswordtext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // updateadminsave
            // 
            this.updateadminsave.Location = new System.Drawing.Point(302, 195);
            this.updateadminsave.Name = "updateadminsave";
            this.updateadminsave.Size = new System.Drawing.Size(64, 34);
            this.updateadminsave.TabIndex = 6;
            this.updateadminsave.Text = "Save";
            this.updateadminsave.UseSelectable = true;
            this.updateadminsave.Click += new System.EventHandler(this.updateadminsave_Click);
            // 
            // updateadminidcombobox
            // 
            this.updateadminidcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminidcombobox.FormattingEnabled = true;
            this.updateadminidcombobox.ItemHeight = 23;
            this.updateadminidcombobox.Location = new System.Drawing.Point(170, 74);
            this.updateadminidcombobox.Name = "updateadminidcombobox";
            this.updateadminidcombobox.Size = new System.Drawing.Size(196, 29);
            this.updateadminidcombobox.TabIndex = 8;
            this.updateadminidcombobox.UseSelectable = true;
            this.updateadminidcombobox.SelectedValueChanged += new System.EventHandler(this.updateadminidcombobox_SelectedValueChanged);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 252);
            this.Controls.Add(this.updateadminidcombobox);
            this.Controls.Add(this.updateadminsave);
            this.Controls.Add(this.updateadminpasswordtext);
            this.Controls.Add(this.updateadminnametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAdmin";
            this.Text = "Update An Admin Information";
            this.Load += new System.EventHandler(this.UpdateAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel label1;
        private MetroLabel label2;
        private MetroLabel label3;
        private MetroTextBox updateadminnametext;
        private MetroTextBox updateadminpasswordtext;
        private MetroButton updateadminsave;
        private MetroComboBox updateadminidcombobox;
    }
}