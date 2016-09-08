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
    public partial class UpdateAdmin : MetroForm
    {
        Admin updateadmin = new Admin();
        AdminData updatedata = new AdminData();
        public UpdateAdmin()
        {
            InitializeComponent();
        }

    

        private void updateadminsave_Click(object sender, EventArgs e)
        {
            if (updateadminidcombobox.Text != "" && updateadminnametext.Text != "" && updateadminpasswordtext.Text != "")
            {
                try
                {

                    updateadmin.adminId = updateadminidcombobox.Text;
                    updateadmin.adminName = updateadminnametext.Text;
                    updateadmin.adminPassword = updateadminpasswordtext.Text;

                    if (updatedata.updateAdmin(updateadmin))
                    {
                        MetroMessageBox.Show(this, $"Successfully updated {updateadmin.adminName}", "Awesome !", MessageBoxButtons.OK, MessageBoxIcon.Question);


                    }
                    else
                    {
                        MetroMessageBox.Show(this, $"We couldn't update {updateadmin.adminName}", "Wait a minute", MessageBoxButtons.OK, MessageBoxIcon.Question);


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

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            List<object> adminid = updatedata.GetAdminIdList();
            updateadminidcombobox.DataSource = adminid;
            updateadminidcombobox_SelectedValueChanged(sender, e);
        }

        private void updateadminidcombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = updateadminidcombobox.Text;
            updateadmin = updatedata.GetAdminUpdateData(id);


            updateadminnametext.Text = updateadmin.adminName;
            updateadminpasswordtext.Text = updateadmin.adminPassword;
        }
    }
}
