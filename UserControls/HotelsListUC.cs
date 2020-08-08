using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking3.UserControls
{
    public partial class HotelsListUC : UserControl
    {
        public HotelsListUC(string City = "")
        {
            InitializeComponent();
                                 
            List<string> cities = SQLClass.Select(
                "SELECT DISTINCT Name FROM cities ORDER BY Name");
            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cities)
                CityComboBox.Items.Add(city);

            //Ищем город
            for (int i = 0; i < CityComboBox.Items.Count; i++)
            { 
                if (CityComboBox.Items[i].ToString() == City)
                {
                    CityComboBox.SelectedIndex = i;
                }
            }

            SortComboBox.SelectedIndex = 0;

            Filter(null, null);
            Admin.AdminDesignForm.ApplyDesign(this);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterPanel.Size.Height < 50)
                FilterPanel.Size = new Size(FilterPanel.Size.Width, 180);
            else
                FilterPanel.Size = new Size(FilterPanel.Size.Width, FilterButton.Size.Height);
        }

        /// <summary>
        /// Открытие гостиницы
        /// </summary>
        private void OpenHotel(object sender, EventArgs e)
        {
            Control pb = (Control)sender;
            HotelUC hf = new HotelUC(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(hf);
            hf.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Открытие номера
        /// </summary>
        private void OpenRoom(object sender, EventArgs e)
        {
            Control pb = (Control)sender;
            RoomUC hf = new RoomUC(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(hf);
            hf.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// ФИльтр
        /// </summary>
        private void Filter(object sender, EventArgs e)
        {
            HotelsPanel.Controls.Clear();
            string command =
                "SELECT hotels.id, hotels.name, hotels.image, hotels.rating, " +
                        "room.id, room.name, room.price, room.image" +
                " FROM  " + SQLClass.ROOM + " JOIN " + SQLClass.HOTELS +
                " ON room.hotel_id = hotels.id" +
                " WHERE 1";

            #region Поиск
            if (CityComboBox.Text != "")
                command += " AND city = '" + CityComboBox.Text + "'";
            if (RatingComboBox.Text != "")
                command += " AND Rating >= " + RatingComboBox.Text;
            if (CapacityComboBox.Text != "")
                command += " AND Capacity >= " + CapacityComboBox.Text;

            foreach (object item in OptionsCheckedListBox.CheckedItems)
            {
                if (item.ToString() == "Для некурящих")
                    command += " AND NoSmoking = 1";
                if (item.ToString() == "Свой санузел")
                    command += " AND Bath = 1";
                if (item.ToString() == "Отдельный номер")
                    command += " AND IsHostel = 0";
                if (item.ToString() == "Wi-Fi")
                    command += " AND WiFi = 1";
            }
            #endregion

            if (SortComboBox.SelectedIndex == 0)
                command += " GROUP BY hotels.id, hotels.name, hotels.image, hotels.rating" +
                            " HAVING room.price = MIN(price) ORDER BY room.Price ASC";
            else if (SortComboBox.SelectedIndex == 1)
                command += " GROUP BY hotels.id, hotels.name, hotels.image, hotels.rating" +
                            " HAVING room.price = MIN(price) ORDER BY room.Price DESC";
            else if (SortComboBox.SelectedIndex == 2)
                command += " GROUP BY hotels.id, hotels.name, hotels.image, hotels.rating" +
                            " HAVING room.price = MIN(price) ORDER BY hotels.rating DESC";

            List<string> hotels = SQLClass.Select(command);

            int x = 15;
            for (int i = 0; i < hotels.Count; i += 8)
            {
                #region Гостиница                
                Label lbl = new Label();
                lbl.Location = new Point(x, 10);
                lbl.Size = new Size(200, 30);
                lbl.Text = hotels[i + 1];
                lbl.Tag = hotels[i];
                lbl.Click += new EventHandler(OpenHotel);
                HotelsPanel.Controls.Add(lbl);
                #endregion


                #region Номер
                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + hotels[i + 7]);
                }
                catch (Exception)
                {
                    try
                    {
                        pb.Load("../../Pictures/2-Seat.jpg");
                    }
                    catch (Exception) { }
                }
                pb.Location = new Point(x, 40);
                pb.Size = new Size(190, 120);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Tag = hotels[i + 4];
                pb.Click += new EventHandler(OpenRoom);
                HotelsPanel.Controls.Add(pb);

                Label lbl2 = new Label();
                lbl2.Location = new Point(x, 170);
                lbl2.Size = new Size(200, 30);
                lbl2.Text = hotels[i + 6] + " рублей";
                lbl2.Tag = hotels[i + 4];
                lbl2.Click += new EventHandler(OpenRoom);
                HotelsPanel.Controls.Add(lbl2);
                #endregion

                x += 205;
            }
        }

    }
}
