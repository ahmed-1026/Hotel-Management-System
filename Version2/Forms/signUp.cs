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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "" && comboBox1.Text != "" )
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Users values(@Username,@Password,@UserType)",con);
                try
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                }
                catch(Exception c)
                {
                    MessageBox.Show("1");
                    MessageBox.Show(c.Message);
                }
                try
                {
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                }
                catch (Exception c)
                {
                    MessageBox.Show("2");
                    MessageBox.Show(c.Message);
                }
                try
                {
                    cmd.Parameters.AddWithValue("@UserType", comboBox1.Text);
                }
                catch (Exception c)
                {
                    MessageBox.Show("3");
                    MessageBox.Show(c.Message);
                }
                bool checker = false;
                try
                {
                    cmd.ExecuteNonQuery();
                    checker = true;
                }
                catch(Exception c)
                {
                    MessageBox.Show("4");
                    MessageBox.Show(c.Message);
                }
                if (checker)
                {
                    MessageBox.Show("Data Added Successfully :)");
                    this.Hide();
                    formLogin frm = new formLogin();
                    frm.Show();
                    //if(MessageBox.Equals == KeyPress);
                }


            }
            else
            {
                MessageBox.Show("Please! Fill all the credentials first :)");
            }

        }
    }
}
