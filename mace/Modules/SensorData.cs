using Newtonsoft.Json;
using System;
using System.Net;

namespace mace.Modules
{
    class SensorData
    {
        public string getTemperature()
        {
            string URI = String.Format($"https://leafreef.herokuapp.com/api/list");

            WebClient client = new WebClient
            {
                UseDefaultCredentials = true
            };

            string json = client.DownloadString(URI);
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            var temperature = data.temperature.ToString();

            return temperature;
        }

        public string getHumidity()
        {
            string URI = String.Format($"https://leafreef.herokuapp.com/api/list");

            WebClient client = new WebClient
            {
                UseDefaultCredentials = true
            };

            string json = client.DownloadString(URI);
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            var humidity = data.humidity.ToString();

            return humidity;
        }
    }
}
