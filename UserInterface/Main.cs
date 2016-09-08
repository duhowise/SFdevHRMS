using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace UserInterface
{
    public partial class Main : MetroForm
    {
         
        adminlogin al = new adminlogin();
        employeelogin el = new employeelogin();
        public Main()
        {
            InitializeComponent();
           
        }

        

        private void adminloginbox_Click(object sender, EventArgs e)
        {
            LoginBox.Controls.Clear();
            leftlogo.Visible = true;
            LoginBox.Controls.Add(al);
            al.Anchor=AnchorStyles.Left;
            adminloginboxbutton.Enabled = false;
            employeloginboxbutton.Enabled = true;

            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            LoginBox.Controls.Clear();
            leftlogo.Visible = true;
            LoginBox.Controls.Add(el);
            el.Anchor=AnchorStyles.None;
           adminloginboxbutton.Enabled = true;
            employeloginboxbutton.Enabled = false;
        }

        

        
    }
}
