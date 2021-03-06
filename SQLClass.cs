﻿using System;
using System.Collections.Generic;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace Booking3
{
    public static class SQLClass
    {
        public const string CONNECTION_STRING =
            "SslMode=none;Server=localhost;Database=booking3;port=3306;User Id=root";

        public static MySqlConnection CONN;

        #region Таблицы
        /// <summary>
        /// Таблица дизайна
        /// </summary>
        public static string BLOCK_DESIGN = "blockDesign";

        /// <summary>
        /// Таблица бронирований
        /// </summary>
        public static string BOOKING = "booking";

        /// <summary>
        /// Таблица городов
        /// </summary>
        public static string CITIES = "cities";

        /// <summary>
        /// Таблица гостиниц
        /// </summary>
        public static string HOTELS = "hotels";

        /// <summary>
        /// Таблица номеров
        /// </summary>
        public static string ROOM = "room";

        /// <summary>
        /// Таблица дизайна
        /// </summary>
        public static string UNIQUE_DESIGN = "uniqueDesign";

        /// <summary>
        /// Таблица людей
        /// </summary>
        public static string USERS = "users2";
        #endregion

        /// <summary>
        /// Select-запрос. Возвращает список строк
        /// </summary>
        public static List<string> Select(string cmdText)
        {
            List<string> list = new List<string>();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, CONN);

                DbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        list.Add(reader.GetValue(i).ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                if (!File.Exists(Path.GetTempPath() + "/booking.txt"))
                    File.Create(Path.GetTempPath() + "/booking.txt");

                File.AppendAllText(Path.GetTempPath() + "/booking.txt",
                    "Ошибка" + Environment.NewLine +
                    DateTime.Now.ToString() + Environment.NewLine +
                    cmdText + Environment.NewLine + 
                    ex.Message + " " + cmdText + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Ошибка");
            }

            return list;
        }

        /// <summary>
        /// Insert/Update/Delete-запрос
        /// </summary>
        public static void Update(string cmdText)
        {
            try
            { 
                MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
                cmd.ExecuteReader();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                if (!File.Exists(Path.GetTempPath() + "/booking.txt"))
                    File.Create(Path.GetTempPath() + "/booking.txt");

                File.AppendAllText(Path.GetTempPath() + "/booking.txt",
                    "Ошибка" + Environment.NewLine +
                    DateTime.Now.ToString() + Environment.NewLine +
                    cmdText + Environment.NewLine +
                    ex.Message + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Ошибка");
            }
        }
    }
}
