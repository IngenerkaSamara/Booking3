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
        public RoomForm(string RoomId)
        {
            InitializeComponent();

            List<string> room_data = SQLClass.Select(
                "SELECT hotel, name, price, image, quantity FROM room WHERE id = " + RoomId);

            Text = room_data[0] + ": " + room_data[1];
            label2.Text = room_data[1];
            label4.Text = room_data[0];
            label6.Text = room_data[2];

            try
            {
                pictureBox1.Load("../../Pictures/" + room_data[3]);
            }
            catch (Exception) { }
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно");
        }
    }
}
