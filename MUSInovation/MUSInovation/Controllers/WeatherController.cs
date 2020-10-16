using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MUSInovation.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MUSInovation.Controllers
{
    public class WeatherController : Controller
    {
        public static Dictionary<string, string> PointsDisponibles = new Dictionary<string, string>(){
            { "New York", "OKX/33,37" },
            { "San Francisco", "MTR/87,126" },
            { "Boston", "BOX/72,76" }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AfficherMeteo(string ville = null)
        {
            string point = null;
            if (ville == null)
                ville = "New York";
            try
            {
               point = PointsDisponibles[ville];
            }
            catch
            {
                point = PointsDisponibles["New York"];
            }
            var clientMeteo = new RestClient("https://api.weather.gov/");
            var request = new RestRequest("/points/" + point + "/forecast", Method.GET);
            IRestResponse response = clientMeteo.Execute(request);
            Weather weather = JsonConvert.DeserializeObject<Weather>(response.Content);
            return View(weather.Properties);
        }
    }
}
