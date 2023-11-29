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
        string received;
        public selectHotel()
        {
            InitializeComponent();
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool checker = false;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select *from Hotels", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if(comboBox1.Text == read["HotelName"].ToString())
                {
                    lblLocation.Text = read["Location"].ToString();
                    lblApproval.Text = read["ApprovalStatus"].ToString();
                    checker = true;
                    break;
                    
                }
            }
            if(checker)
            {
            read.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" || lblApproval.Text == "" || lblLocation.Text == "")
            {
                MessageBox.Show("Firstly Select Hotel");
            }
            else
            {
                List<string> formList = DataStorage.Instance.SharedList;
                
                ////Here i am taking userID from User table
                string userName = formList[formList.Count - 1];
                // Second Method of taking userID.
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select UserID from Users where Username = @Username", con);
                cmd.Parameters.AddWithValue("@Username",userName);
                object result = cmd.ExecuteScalar(); // Use ExecuteScalar to get a single value
                int userID = Convert.ToInt32(result);
                //MessageBox.Show(userID.ToString());

                //MessageBox.Show(Userid.ToString());


                ////Here i am taking Hotelid from Hotel-table
                int hotelId = 0;
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select HotelID from Hotels where HotelName = @HotelName", con1);
                cmd1.Parameters.AddWithValue("@HotelName", comboBox1.Text);
                object result1 = cmd1.ExecuteScalar();
                hotelId = Convert.ToInt32(result1);
                List<int> list = DataStorage.Instance.IDs;
                list.Add(hotelId);
                //MessageBox.Show(list.Count.ToString());

                //MessageBox.Show(hotelId.ToString());

                // Here I am insert values in UserHotelAcsess.
                bool check = false;
                var con3 = Configuration.getInstance().getConnection();
                SqlCommand cmd3 = new SqlCommand("Insert into UserHotelAccess Values(@UserID,@HotelID,@UserType)", con3);
                cmd3.Parameters.AddWithValue("@UserID",userID);
                cmd3.Parameters.AddWithValue("@HotelID",hotelId);
                cmd3.Parameters.AddWithValue("@UserType","User");
                try
                {
                    cmd3.ExecuteNonQuery();
                    check = true;
                }
                catch(Exception c)
                {
                    MessageBox.Show(c.Message);
                }
                if (check)
                {
                    MessageBox.Show("Data Added :)");
                }


            }
        }

        private void selectHotel_Load(object sender, EventArgs e)
        {
            
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select *from Hotels", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["HotelName"].ToString()); 
            }
            read.Close();
        }
    }
}
