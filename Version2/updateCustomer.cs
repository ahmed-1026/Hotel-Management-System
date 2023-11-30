using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version2
{
    public partial class updateCustomer : UserControl
    {
        public updateCustomer()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtCnic.Text == "" && txtEmail.Text == "" && txtName.Text == "" && txtPhone.Text == "")
            {
                MessageBox.Show("Fill atleast one textbox");
            }
            else
            {
                MessageBox.Show("llllllllllllllllllllllllllloooooooooooooooollllllllllllll");
            }
        }
    }
}
