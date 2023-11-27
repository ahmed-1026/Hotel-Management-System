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
    public partial class addHotel : UserControl
    {
        public addHotel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtApproval.Text == "" || txtHotel.Text == "" || txtLocation.Text == "")
            {
                MessageBox.Show("Please! Fill all the credentials first :)");
            }
            else
            {
                bool check = false;
                int selected = 0;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Hotels values(@HotelName,@Location,@ApprovalStatus,@Selected)", con);
                cmd.Parameters.AddWithValue("@HotelName", txtHotel.Text);
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                cmd.Parameters.AddWithValue("@ApprovalStatus", txtApproval.Text);
                cmd.Parameters.AddWithValue("@Selected", selected);
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch(Exception c)
                {
                    MessageBox.Show(c.Message);
                }
                if (check)
                {
                    MessageBox.Show("Data Added Suiccessfully");
                }
            }

        }
    }
}
