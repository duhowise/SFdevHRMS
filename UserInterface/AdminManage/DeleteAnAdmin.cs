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
    public partial class DeleteAnAdmin : MetroForm
    {
        Admin deleteadmininformation = new Admin();
        AdminData ad = new AdminData();

        public DeleteAnAdmin()
        {
            InitializeComponent();
        }


        private void deleteadmin_Click_1(object sender, EventArgs e)
        {
            var dialogResult = MetroMessageBox.Show(this, $"Are you sure you want to delete {deleteadminidcomboBox.SelectedItem} ?","Wait a minute",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            

            if (dialogResult==DialogResult.Yes)
            {
                #region DeleteAdmin
                deleteadmininformation.adminId = deleteadminidcomboBox.Text;
                if (deleteadminidcomboBox.Text != "")
                {
                    new EmployeeJobAssignData().deleteFromJobAssign(deleteadminidcomboBox.Text);
                    new PerformanceData().deleteFromPerformance(deleteadminidcomboBox.Text);
                    try
                    {
                        if (ad.deleteAdmin(deleteadmininformation))
                        {
                            MetroMessageBox.Show(this,$"Successfully Deleted {deleteadmininformation.adminName}", "Wait a minute",MessageBoxButtons.OK, MessageBoxIcon.Question);
                            DeleteAnAdmin_Load(sender, e);
                        }

                        else
                        {
                            MetroMessageBox.Show(this, $"Couldnt delete {deleteadmininformation.adminName}", "Wait a minute", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                #endregion
            }
           
        }

        private void DeleteAnAdmin_Load(object sender, EventArgs e)
        {
            List<object> adminid = ad.GetAdminIdList();
            deleteadminidcomboBox.DataSource = adminid;
        }
    }
}
