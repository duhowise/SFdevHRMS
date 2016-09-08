using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace UserInterface.AdminManage
{
    public partial class AddNewAdmin : MetroForm
    {
        Admin addnewadmin = new Admin();
        AdminData admind = new AdminData();
        public AddNewAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            adminidaddtext.Focus();
            this.Resizable = false;
        }

        private void buttonadmininsert_Click(object sender, EventArgs e)
        {
            if (adminidaddtext.Text != "" && adminnametext.Text != "" && adminpasswordtext.Text != "")
            {
                try
                {
                    addnewadmin.adminId = adminidaddtext.Text;
                    addnewadmin.adminName = adminnametext.Text;
                    addnewadmin.adminPassword = adminpasswordtext.Text;

                    if (admind.insertAdmin(addnewadmin))
                    {
                        MessageBox.Show("Saved Admin Information");
                        MetroMessageBox.Show(this, $"Successfully saved {addnewadmin.adminName}", "Awesome!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        clearadminadd_Click(sender, e);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "You have to enter some data", "Wait a minute", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearadminadd_Click(sender, e);

                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"Something went wrong {ex.Message}", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "You have to enter some data", "Wait a minute", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clearadminadd_Click(object sender, EventArgs e)
        {
            adminidaddtext.Text = "";
            adminnametext.Text = "";
            adminpasswordtext.Text = "";


        }

    }
}
