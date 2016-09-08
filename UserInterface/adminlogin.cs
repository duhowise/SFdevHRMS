using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using DataLayer;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;



namespace UserInterface
{
    
    public partial class adminlogin :MetroUserControl
    {
        
        Admin admin = new Admin();
        
        AdminLogin adlogin = new AdminLogin();
        public adminlogin()
        {
            InitializeComponent();
            adminid.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            admin.adminId = adminid.Text;
            admin.adminPassword = adminpassword.Text;

            try
            {

                if (adlogin.AdminValid(admin))
                {
                    AdminManage.AdminMain am = new AdminManage.AdminMain(admin);
                    am.Show();
                    this.Parent.Parent.Visible = false;


                }
                else
                {
                    MetroMessageBox.Show(this, "Please Check Your Credentials","Hey there!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }

            }

            catch(Exception exc)
            {
                MetroMessageBox.Show(this, $"Something went wrong {exc.Message}", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
                
               
            
          
        

        private void adminpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Logout()
        {
            
            this.Parent.Parent.Visible = true;
        }

        private void adminid_TextChanged(object sender, EventArgs e)
        {

        }

        

      

    }
}
