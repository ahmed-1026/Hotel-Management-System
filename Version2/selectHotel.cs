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
    public partial class selectHotel : UserControl
    {
        public selectHotel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Pearl Continental Hotel")
            {
                lblLocation.Text = "Shahrah - e - Quaid - e - Azam";
            }
            else if(comboBox1.Text =="Avari Hotel") 
            {
                lblLocation.Text = "87 Shahrah-e-Quaid-e-Azam";
            }
            else if(comboBox1.Text == "Lahore Marriott Hotel")
            {
                lblLocation.Text = " Aga Khan Road, Shalimar 5-PO Box 3003";
            }
            else if(comboBox1.Text == "Faletti's Hotel")
            {
                lblLocation.Text = "Egerton Road";
            }
            else
            {
                lblLocation.Text = "9A, Gulberg III, Mian Mehmood Ali Kasoori Road";
            }
            lblApproval.Text = "Active";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Firstly Select Hotel");
            }
            else
            {
                bool check = false;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Hotels values(@HotelName,@Location,@ApprovalStatus)",con);
                cmd.Parameters.AddWithValue("@HotelName", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Location", lblLocation.Text);
                cmd.Parameters.AddWithValue("@ApprovalStatus", lblApproval.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch(Exception C)
                {
                    MessageBox.Show(C.Message);
                }
                if (check)
                {
                    MessageBox.Show("Data Added Successfully :)");
                }



            }
        }
    }
}
