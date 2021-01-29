
using RestSharp;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Facade
{
    public class Forecast : IForecast
    {
        public string GetForecast(string city)
        {
            string APIKey = ""; // put your API key here
            // Connection String
            var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={APIKey}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Deserialize the string content into JToken object
                return response.Content;
                
         
            }

            return null;
        }
    }
}
