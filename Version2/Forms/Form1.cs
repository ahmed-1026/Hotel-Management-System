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
//Using Forms;

namespace Version2
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "" || txtUsername.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please! Fill in all the credentials first :)");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select *from Users", con);
                string userName = "";
                    string userPassword = "";
                    string userType = "";
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool checker = false;
                    while (reader.Read())
                    {
                        userName = reader["Username"].ToString();
                        userPassword = reader["Password"].ToString();
                        userType = reader["UserType"].ToString();
                        if (userName == txtUsername.Text && userPassword == txtPassword.Text && userType == comboBox1.Text)
                        {
                            checker = true;
                            reader.Close();
                            break;
                        }
                        
                    }

                    if (checker)
                    {
                        this.Hide();
                        dashboard1 form = new dashboard1(userName);
                        form.Show();
                    }
                    if (!checker)
                    {
                        MessageBox.Show("Invalid Credentials :)");
                        reader.Close(); // here i  will create issue for pushing onto git hub.
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        comboBox1.Text = "";
                        

                    }
                   // MessageBox.Show(userName + " " + userPassword + "" + userType);
            }

 }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp frm = new signUp();
            frm.Show();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
