using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeatherAppAPI
{
    internal class WeatherInfo
    {
        public class Coord
        {
            public double Lon { get; set; } // Matches "lon" in JSON
            public double Lat { get; set; } // Matches "lat" in JSON
        }

        public class Weather
        {
            [JsonProperty("main")]
            public string currentWeather { get; set; } // Matches "main" in JSON (e.g., "Clouds")
            public string Description { get; set; } // Matches "description" in JSON (e.g., "overcast clouds")

            public string Icon { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; } // Matches "temp" in JSON
            public double Pressure { get; set; } // Matches "pressure" in JSON
            public double Humidity { get; set; } // Matches "humidity" in JSON

            [JsonProperty("sea_level")]
            public int SeaLevel {  get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; } // Matches "speed" in JSON
        }

        public class Root
        {
            public Coord Coord { get; set; } // Matches "coord" in JSON
            public List<Weather> Weather { get; set; } // Matches "weather" in JSON
            public Main Main { get; set; } // Matches "main" in JSON
            public Wind Wind { get; set; } // Matches "wind" in JSON
        }
    }
}
