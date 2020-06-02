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
        public MainForm()
        {
            InitializeComponent();
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
            HotelForm hf = new HotelForm(pb.Tag.ToString());
            hf.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            HotelForm hf = new HotelForm(pb.Text);
            hf.Show();
        }
    }
}
