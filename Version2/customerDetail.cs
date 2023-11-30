using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Version2
{
    public partial class customerDetail : UserControl
    {
        public customerDetail()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checker = false;
            if(txtCnic.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please! Fill all the Credentials First :)");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Insert into Customers values(@Name,@CNIC,@Phone,@Email)",con);
                cmd1.Parameters.AddWithValue("@Name", txtName.Text);
                cmd1.Parameters.AddWithValue("@CNIC", txtCnic.Text);
                cmd1.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                try
                {
                    cmd1.ExecuteNonQuery();
                    checker = true;
                }
                catch(Exception C)
                {
                    MessageBox.Show(C.Message);
                }
                if (checker)
                {
                    MessageBox.Show("Data Added Successfully :)");

                    //this.Hide();
                    //selectHotel ffm = new selectHotel();
                    //ffm.Show();
                }

            }
        }

        private void customerDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
