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
        string id;

        public HotelForm(string hotel_id)
        {
            InitializeComponent();

            OpinionPanel.Visible = (MainForm.Login != "");

            List<string> hotels = MainForm.MySelect(
                "SELECT Name, City, Image, Rating, id FROM hotels" +
                " WHERE id = '" + hotel_id + "'");

            HotelName = hotels[0];
            id = hotel_id;
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

            //Номера
            List<string> rooms = MainForm.MySelect("SELECT id, name, price, image FROM room WHERE hotel_id = " + id);

            x = 15;
            HotelsPanel.Controls.Clear();
            for (int i = 0; i < rooms.Count; i+= 4)
            {
                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + rooms[i + 3]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 10);
                pb.Size = new Size(190, 120);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Tag = rooms[i];
                //pb.Click += new EventHandler(pictureBox1_Click);
                HotelsPanel.Controls.Add(pb);

                Label lbl = new Label();
                lbl.Font = new Font("Arial", 10);
                lbl.Location = new Point(x, 140);
                lbl.Size = new Size(200, 30);
                lbl.Text = rooms[i + 1] + " (" + rooms[i+2] +")";
                lbl.Tag = rooms[i];
                //lbl.Click += new EventHandler(label4_Click);
                HotelsPanel.Controls.Add(lbl);

                x += 205;
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
