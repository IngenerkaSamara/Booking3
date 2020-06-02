using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking3
{
    public partial class HotelForm : Form
    {
        string HotelName;

        public HotelForm (string _HotelName)
        {
            HotelName = _HotelName;
            InitializeComponent();

            if (HotelName == "Гостиница \"Апрель\"")
            {
                pictureBox1.Load("../../Pictures/093475.jpg");
            }
            else if (HotelName == "Гостиница \"Советская\"")
            {
                pictureBox1.Load("../../Pictures/875875.jpg");
            }
            else if (HotelName == "Хостел \"Так надо\"")
            {
                pictureBox1.Load("../../Pictures/16849602.jpg");
            }

            Text = HotelName;
            label4.Text = HotelName;
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(HotelName, pb.Tag.ToString());
            rf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            RoomForm rf = new RoomForm(HotelName, pb.Text);
            rf.Show();
        }
    }
}
