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
    public partial class dashBoard2 : Form
    {
        private string received;
        public dashBoard2(string passedVariable)
        {
            InitializeComponent();
            received = passedVariable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashBoard2_Load(object sender, EventArgs e)
        {
            this.label2.Text = "Welcome " + received;
            addHotel1.Hide();
            addRoom1.Hide();


        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin frm = new formLogin();
            frm.Show();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            mainPicture1.Hide();
            addRoom1.Hide();
            addHotel1.Show();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            mainPicture1.Hide();
            addHotel1.Hide();
            addRoom1.Show();
        }
    }
}
