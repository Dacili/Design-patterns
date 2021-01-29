
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Facade
{
    public class ForecastMinInfo : IForecastMin
    {
       public string GetForecastMiniInfo(string city)
        {
            var forecastFull = new Forecast();
            var minified = forecastFull.GetForecast(city);
            return minified.Split(",")[minified.Split(",").Length-2] + '\n'+
                minified.Split(",")[3]+'\n'+ minified.Split(",")[4];
        }

    }



    public class WeatherResponseMin
    {
        
        public string Weather { get; set; }
      //  public string Base { get; set; }
       // public int Visibility { get; set; }
       // public Main Main { get; set; }
       public float Temp { get; set; }
        public int Dt { get; set; }
        public int Timezone { get; set; }
        public string Name { get; set; }

        public string toString()
        {
            return "Temp:" + Temp;

        }

    }


    public class Weather
    {
       
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }

        
    }

    public class Main
    {
        public float Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public float Temp_Min { get; set; }
        public float Temp_Max { get; set; }

    }

}