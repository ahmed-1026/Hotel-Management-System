using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version2
{
    public partial class addRoom : UserControl
    {
        int hotelId = 0;
        public addRoom()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select HotelID from Hotels where HotelName = @HotelName", con1);
            cmd1.Parameters.AddWithValue("@HotelName", comboBox1.Text);
            object result1 = cmd1.ExecuteScalar();
            hotelId = Convert.ToInt32(result1);
            MessageBox.Show(hotelId.ToString());

        }

        private void addRoom_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || txtRoomNo.Text == "" || txtPrice.Text == "" || txtRoomType.Text == "")
            {
                MessageBox.Show("Fill All the Credentials first");
            }
            else
            {
                bool check = false;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Rooms Values(@HotelID,@RoomNumber,@RoomType,@PricePerNight)", con);
                cmd.Parameters.AddWithValue("@HotelID",hotelId);
                cmd.Parameters.AddWithValue("@RoomNumber",int.Parse(txtRoomNo.Text));
                cmd.Parameters.AddWithValue("@RoomType",txtRoomType.Text);
                cmd.Parameters.AddWithValue("@PricePerNight",int.Parse(txtPrice.Text));
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
                    MessageBox.Show("Data Added Successfully :)");
                    comboBox1.Text = "";
                    txtPrice.Text = "";
                    txtRoomNo.Text = "";
                    txtRoomType.Text = "";
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
