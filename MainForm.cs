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
    public partial class MainForm : Form
    {
        List<Hotel> hotels_list = new List<Hotel>();

        public MainForm()
        {
            InitializeComponent();

            string[] lines = System.IO.File.ReadAllLines("Гостиницы.txt");

            foreach(string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                if (parts.Length >= 4)
                {
                    Hotel hotel = new Hotel(parts[0], parts[1], 
                        Convert.ToInt32(parts[2]), parts[3]);
                    hotels_list.Add(hotel);
                }
            }

            int x = 15;
            foreach (Hotel hotel in hotels_list)
            {
                hotel.pb.Location = new Point(x, 10);
                hotel.pb.Size = new Size(190, 120);
                hotel.pb.SizeMode = PictureBoxSizeMode.StretchImage;
                hotel.pb.Tag = hotel.Name;
                hotel.pb.Click += new EventHandler(pictureBox1_Click);
                HotelsPanel.Controls.Add(hotel.pb);

                hotel.lbl.Location = new Point(x, 140);
                hotel.lbl.Size = new Size(200, 30);
                hotel.lbl.Text = hotel.Name;
                hotel.lbl.Click += new EventHandler(label4_Click);
                HotelsPanel.Controls.Add(hotel.lbl);

                x += 205;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterPanel.Size.Height < 50)
                FilterPanel.Size = new Size(FilterPanel.Size.Width, 120);
            else
                FilterPanel.Size = new Size(FilterPanel.Size.Width, FilterButton.Size.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            
            foreach (Hotel hotel in hotels_list)
            {
                if (hotel.pb.Image == pb.Image)
                {
                    HotelForm hf = new HotelForm(hotel);
                    hf.Show();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;

            foreach (Hotel hotel in hotels_list)
            {
                if (hotel.Name == pb.Text)
                {
                    HotelForm hf = new HotelForm(hotel);
                    hf.Show();
                }
            }
        }

        /// <summary>
        /// ФИльтр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Hotel hotel in hotels_list)
            {
                bool Visible = true;
                if (CityComboBox.Text != "" && CityComboBox.Text != hotel.City)
                {
                    Visible = false;
                }

                hotel.lbl.Visible = Visible;
                hotel.pb.Visible = Visible;
            }
        }
    }
}
