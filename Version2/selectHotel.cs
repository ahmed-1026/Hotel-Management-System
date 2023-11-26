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
        }
    }
}
