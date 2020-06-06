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
    /// <summary>
    /// Гостиница
    /// </summary>
    public struct Hotel
    {
        public string Name;
        public string City;
        public int Rating;
        public string PictureAddress;
        public PictureBox pb;
        public Label lbl;

        public Hotel(string _Name, string _City, int _Rating, string _Address)
        {
            Name = _Name;
            City = _City;
            Rating = _Rating;
            PictureAddress = _Address;
            pb = new PictureBox();
            try
            {
                pb.Load("../../Pictures/" + _Address);
            }
            catch (Exception) { }

            lbl = new Label();
        }
    }

    public partial class HotelForm : Form
    {
        string HotelName;
        string id;

        public HotelForm (Hotel hotel)
        {
            InitializeComponent();

            List<string> hotels = MainForm.MySelect(
                "SELECT Name, City, Image, Rating, id FROM hotels" +
                " WHERE Name = '" + hotel.Name + "'");

            HotelName = hotels[0];
            id = hotels[4];
            try
            {
                pictureBox1.Load("../../Pictures/" + hotels[2]);
            }
            catch (Exception) { }

            Text = hotels[0];
            label4.Text = hotels[0];

            //Рисование звезд
            int x = 275;
            for (int i = 0; i < Convert.ToInt32(hotels[3]); i++)
            {
                PictureBox box = new PictureBox();
                box.Location = new Point(x, 64);
                box.Load("../../Pictures/star.png");
                box.Size = new Size(33, 33);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                InfoPanel.Controls.Add(box);
                x += 40;
            }
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

        private void OpinionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpinionCLick(object sender, EventArgs e)
        {
            MainForm.MyUpdate("INSERT INTO rating(user, hotel_id, rate, comment) VALUES(" +
                "'" + MainForm.Login + "', " +
                "'" + id + "', " +
                "'" + numericUpDown1.Value.ToString() + "', " +
                "'" + textBox1.Text + "')");
            MessageBox.Show("Спасибо");
        }
    }
}
