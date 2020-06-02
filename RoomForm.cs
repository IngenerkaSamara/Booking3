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
    public partial class RoomForm : Form
    {
        public RoomForm(string HotelName, string RoomName)
        {
            InitializeComponent();

            Text = HotelName + ": " + RoomName;
            label2.Text = RoomName;
            label4.Text = HotelName;

            if (RoomName == "Одноместный номер")
            {
                pictureBox1.Load("../../Pictures/1-Seat.jpg");
            }
            else if (RoomName == "Двухместный номер")
            {
                pictureBox1.Load("../../Pictures/2-Seat.jpg");
            }
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
