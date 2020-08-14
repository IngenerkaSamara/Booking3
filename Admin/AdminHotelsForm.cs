using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Booking3.Admin
{
    public partial class AdminHotelsForm : UserControl
    {
        public AdminHotelsForm()
        {
            InitializeComponent();
        }

        string address = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);

                try
                {
                    System.IO.File.Copy(address, "../../Pictures/" + System.IO.Path.GetFileName(address));
                }
                catch (Exception) { }

                address = System.IO.Path.GetFileName(address);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Update(
                "INSERT INTO  " + SQLClass.HOTELS + " (Name, City, Rating, Image)" +
                " VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + 
                                textBox3.Text + "', '" + address + "')");
            MessageBox.Show("Сохранено");
        }

        /// <summary>
        /// Рисование компонентов
        /// </summary>
        private void AdminHotelsForm_Load(object sender, EventArgs e)
        {
            List<string> hotels_list = SQLClass.Select(
                "SELECT Name, City, Rating, id FROM " + SQLClass.HOTELS);

            panel2.Controls.Clear();
            int y = 15;
            for (int i = 0; i < hotels_list.Count; i += 4)
            {
                Label lbl = new Label();
                lbl.Location = new Point(0, y);
                lbl.Size = new Size(200, 30);
                lbl.Text = hotels_list[i];
                panel2.Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Location = new Point(200, y);
                lbl2.Size = new Size(100, 30);
                lbl2.Text = hotels_list[i + 1];
                panel2.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(300, y);
                lbl3.Size = new Size(100, 30);
                lbl3.Text = hotels_list[i + 2];
                panel2.Controls.Add(lbl3);

                Button btn = new Button();
                btn.Text = "Удалить";
                btn.Location = new Point(400, y);
                btn.Size = new Size(100, 30);
                btn.Click += new EventHandler(DeleteHotel);
                panel2.Controls.Add(btn);

                Button btn2 = new Button();
                btn2.Text = "Обновить";
                btn2.Tag = hotels_list[i+3];
                btn2.Location = new Point(500, y);
                btn2.Size = new Size(100, 30);
                btn2.Click += new EventHandler(RefreshHotel);
                panel2.Controls.Add(btn2);

                y += 30;
            }
        }

        /// <summary>
        /// Обновление цены
        /// </summary>
        private void RefreshHotel(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Read(btn.Tag.ToString());
        }

        /// <summary>
        /// Цены на отели
        /// </summary>
        public static void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            string sReadData = webBrowser.Document.Body.InnerHtml;

            string[] parts = sReadData.Split(
                new string[] { "hprt-roomtype-link" },
                StringSplitOptions.None);

            for (int i = 1; i < parts.Length; i++)
            {
                #region Поиск названия
                string[] roomParts = parts[i].Split(new char[] { '\n' });

                string id = roomParts[0];
                int pos1 = id.IndexOf("href");
                int pos2 = id.IndexOf(" ", pos1 + 1);
                id = id.Substring(pos1 + 7, pos2 - pos1 - 8);
                string room = roomParts[2];
                #endregion


                #region Поиск цены
                string[] priceParts = parts[i].Split(
                    new string[] { "bui-price-display__value prco-text-nowrap-helper prco-font16-helper" },
                    StringSplitOptions.None);
                int Price = 10000;

                for (int j = 1; j < priceParts.Length; j++)
                {
                    pos1 = priceParts[j].IndexOf("\n");
                    pos2 = priceParts[j].IndexOf("&nbsp", pos1 + 1);
                    try
                    {
                        string price = priceParts[j].Substring(pos1 + 1, pos2 - pos1 - 1);
                        int currentPrice = Convert.ToInt32(price.Replace(" ", ""));
                        if (currentPrice < Price)
                            Price = currentPrice;
                    }
                    catch (Exception) { }
                }
                #endregion

                SQLClass.Update("UPDATE " + SQLClass.ROOM +
                    " SET Name = '" + room + "'" +
                    ", Price = " + Price +
                    " WHERE IdBooking = '" + id + "'");
            }

            MessageBox.Show("OK");
            webBrowser.Dispose();
        }

        /// <summary>
        /// Цены на отели
        /// </summary>
        public static void Read(string hotelId)
        {
            string link = SQLClass.Select("SELECT link FROM " + SQLClass.HOTELS +
                " WHERE id=" + hotelId)[0];

            if (link != "")
            {
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.DocumentCompleted += webBrowser1_DocumentCompleted;
                webBrowser.Navigate(link);
            }
        }



        private void DeleteHotel(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in panel2.Controls)
            {
                if (control.Location == new Point(0, y))
                {
                    SQLClass.Update(
                        "DELETE FROM " + SQLClass.HOTELS +
                        " WHERE Name = '" + control.Text + "'");
                    
                    AdminHotelsForm_Load(sender, e);
                    return;
                }
            }
        }
    }
}
