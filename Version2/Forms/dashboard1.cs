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
    public partial class dashboard1 : Form
    {
        public string received;
        public dashboard1(string passedVariable)
        {
            InitializeComponent();
            received = passedVariable;
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show(received);
            this.label2.Text = "Welcome "+received;
            selectHotel1.Hide();
            customerDetail1.Hide();
            selectRoom1.Hide();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Height.ToString() + this.Width.ToString());
            this.Hide();
            formLogin frm = new formLogin();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            mainPicture1.Hide();
            selectHotel1.Hide();
            selectRoom1.Hide();
            customerDetail1.Show();
        }

        private void btnSelectHotel_Click(object sender, EventArgs e)
        {
            List<string> formList = DataStorage.Instance.SharedList;
            formList.Add(received);
            mainPicture1.Hide();
            customerDetail1.Hide();
            selectRoom1.Hide();
            selectHotel1.Show();
        }

        private void selectHotel1_Load(object sender, EventArgs e)
        {

        }

        private void panelUpper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            mainPicture1.Hide();
            customerDetail1.Hide();
            selectHotel1.Hide();
            selectRoom1.Show();
        }
    }
}
