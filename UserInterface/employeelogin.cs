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

namespace UserInterface
{
    public partial class employeelogin : MetroUserControl
    {
        Employee ep = new Employee();
        EmployeeLogin el = new EmployeeLogin();

        public employeelogin()
        {
            InitializeComponent();
        }

        private void employeeloginbutton_Click(object sender, EventArgs e)
        {
            ep.employeeId = employeeid.Text;
            ep.employeePassword = employeepassword.Text;
            try
            {

                if (el.EmployeeValid(ep))
                {
                    EmployeeManage.EmployeeMain em = new EmployeeManage.EmployeeMain(ep);
                    em.Show();
                    this.Parent.Parent.Visible = false;
                }
                else
                {
                    MetroMessageBox.Show(this, "Wrong Credentials", "Hey there!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception exc)
            {

                MetroMessageBox.Show(this, exc.Message, "Something Went Wrong !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void employeepassword_TextChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
