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
    public partial class selectRoom : UserControl
    {
        int id_of_room = 0;
        int id_of_hotel = 0;
        int id_of_customer  = 0;
        public selectRoom()
        {
            InitializeComponent();
        }

        private void selectRoom_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            //int id_of_room = 0;
            //int id_of_hotel = 0;
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            //    id_of_room = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
            //    id_of_hotel = Convert.ToInt32(selectedRow.Cells["HotelID"].Value);
            //    MessageBox.Show(id_of_room.ToString() + "   " + id_of_hotel.ToString());
            //}
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = DataStorage.Instance.IDs;
            if (list.Count == 0)
            {
                MessageBox.Show("Firstly Select Hotel");
            }
            else
            {
                int hotelid = list[0];
                list.Clear();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select *from rooms where hotelid=@hotelid", con);
                cmd.Parameters.AddWithValue("@hotelid", hotelid);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(hotelid.ToString());
                    //messagebox.show()
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                // Here i am taking Customer id
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("select MAX(c.CustomerID) from Customers AS c", con1);
                object result = cmd1.ExecuteScalar();
                //MessageBox.Show(Convert.ToInt32(result).ToString());
                id_of_customer = Convert.ToInt32(result);
                list.Add(id_of_customer);

                MessageBox.Show(list.Count.ToString());


               




            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                id_of_room = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                id_of_hotel = Convert.ToInt32(selectedRow.Cells["HotelID"].Value);
                MessageBox.Show(id_of_room.ToString() + "   " + id_of_hotel.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkInDTPicker.Checked = false;
            checkOutDTPicker.Checked = false;
            bool check = false;
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("Insert into Reservations values(@CustomerID,@HotelID,@CheckInDate,@CheckOutDate,@NumberOfOccupants,@RoomID)", con2);
            cmd2.Parameters.AddWithValue("@CustomerID", id_of_customer);
            cmd2.Parameters.AddWithValue("@HotelID", id_of_hotel);
            cmd2.Parameters.AddWithValue("@CheckInDate", checkInDTPicker.Value);
            cmd2.Parameters.AddWithValue("@CheckOutDate", checkOutDTPicker.Value);
            cmd2.Parameters.AddWithValue("@NumberOfOccupants", txtOccupants.Text);
            cmd2.Parameters.AddWithValue("@RoomID", id_of_room);
            try
            {
                cmd2.ExecuteNonQuery();
                check = true;
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
            if (check)
            {
                MessageBox.Show("Room Selected");
            }

        }
    }
}
