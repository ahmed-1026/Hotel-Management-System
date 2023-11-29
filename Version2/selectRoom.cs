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
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select *from rooms where hotelid=@hotelid", con);
                cmd.Parameters.AddWithValue("@hotelid", hotelid);
                try
                {
                    cmd.ExecuteNonQuery();
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
                //dataGridView1.ReadOnly = true;


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_of_room = 0;
            int id_of_hotel = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                id_of_room = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                id_of_hotel = Convert.ToInt32(selectedRow.Cells["HotelID"].Value);
                MessageBox.Show(id_of_room.ToString() + "   " + id_of_hotel.ToString());
            }
        }
    }
}
