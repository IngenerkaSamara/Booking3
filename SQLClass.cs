using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Booking3
{
    public static class SQLClass
    {
        public const string CONNECTION_STRING =
            "SslMode=none;Server=localhost;Database=booking3;port=3306;User Id=root";

        public static MySqlConnection CONN;

        /// <summary>
        /// Select-запрос. Возвращает список строк
        /// </summary>
        public static List<string> Select(string cmdText)
        {
            List<string> list = new List<string>();

            MySqlCommand cmd = new MySqlCommand(cmdText, CONN);

            DbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    list.Add(reader.GetValue(i).ToString());
            }

            reader.Close();

            return list;
        }

        /// <summary>
        /// Insert/Update/Delete-запрос
        /// </summary>
        public static void Update(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
            cmd.ExecuteReader();
            cmd.Dispose();
        }
    }
}
