using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace Booking3
{
    public static class ValuteClass
    {
        /// <summary>
        /// Курсы валют
        /// </summary>
        public static Dictionary<string, double> vals = new Dictionary<string, double>();

        public static void FillVals()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "https://www.cbr-xml-daily.ru/daily_json.js");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();


            dynamic d = JsonConvert.DeserializeObject(sReadData);
            string usd = d.Valute.USD.Value.ToString();
            string eur = d.Valute.EUR.Value.ToString();
            string gbp = d.Valute.GBP.Value.ToString();

            double Usd = Convert.ToDouble(usd);
            double Eur = Convert.ToDouble(eur);
            double Gbp = Convert.ToDouble(gbp);

            vals.Add("Рубли", 1);
            vals.Add("Доллары", Usd);
            vals.Add("Евро", Eur);
            vals.Add("Фунты", Gbp);
        }
    }
}
