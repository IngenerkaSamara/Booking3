﻿using System;
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
            pb.Load("../../Pictures/" + _Address);
            lbl = new Label();
        }
    }

    public partial class HotelForm : Form
    {
        string HotelName;

        public HotelForm (Hotel hotel)
        {
            HotelName = hotel.Name;
            InitializeComponent();

            
            pictureBox1.Image = hotel.pb.Image;            
            Text = hotel.Name;
            label4.Text = hotel.Name;

            //Рисование звезд
            int x = 275;
            for (int i = 0; i < hotel.Rating; i++)
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
    }
}
