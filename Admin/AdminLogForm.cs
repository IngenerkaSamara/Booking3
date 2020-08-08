using System;
using System.IO;
using System.Windows.Forms;

namespace Booking3.Admin
{
    public partial class AdminLogForm : UserControl
    {
        public AdminLogForm()
        {
            InitializeComponent();
        }

        private void AdminLogForm_Load(object sender, EventArgs e)
        {
            //ПРоверка существования лог-файла
            if (!File.Exists(Path.GetTempPath() + "/booking.txt"))
            {
                File.Create(Path.GetTempPath() + "/booking.txt");
            }

            //Чтение лог-файла
            try
            {
                string Text = File.ReadAllText(Path.GetTempPath() + "/booking.txt");

                string[] lines = Text.Split(new string[] { "Ошибка" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string error in lines)
                {
                    string[] parts = error.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    dataGridView1.Rows.Add(parts);
                }
            }
            catch (Exception)
            {
                if (!File.Exists(Path.GetTempPath() + "/booking.txt"))
                    File.Create(Path.GetTempPath() + "/booking.txt");

                File.AppendAllText(Path.GetTempPath() + "/booking.txt",
                    "Ошибка" + Environment.NewLine +
                    DateTime.Now.ToString() + Environment.NewLine +
                    "Не удалось открыть лог-файл" + Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
