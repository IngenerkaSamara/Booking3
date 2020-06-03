using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Booking3
{
    static class Program
    {
        public const string CONNECTION_STRING =
            "SslMode=none;Server=localhost;Database=booking3;port=3306;User Id=root";

        public static MySqlConnection CONN;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CONN = new MySqlConnection(CONNECTION_STRING);
            CONN.Open();

            Application.Run(new MainForm());

            CONN.Close();
        }
    }
}
