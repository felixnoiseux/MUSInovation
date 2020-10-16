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
        public static readonly Dictionary<string, string> PointsDisponibles = new Dictionary<string, string>(){
            { "NY", "OKX/33,37" },
            { "SF", "MTR/87,126" },
            { "BOS", "BOX/72,76" }
        };

        public IActionResult AfficherMeteo(Properties prop = null)
        {
            string ville = null;
            if (prop != null)
                ville = prop.Ville;
            string point = null;
            if (ville == null)
                ville = "NY";
            try
            {
               point = PointsDisponibles[ville];
            }
            catch
            {
                point = PointsDisponibles["NY"];
            }
            var clientMeteo = new RestClient("https://api.weather.gov/");
            var request = new RestRequest("/gridpoints/" + point + "/forecast", Method.GET);
            IRestResponse response = clientMeteo.Execute(request);
            Properties properties = JsonConvert.DeserializeObject<Weather>(response.Content).Properties;
            properties.Ville = ville;
            return View(properties);
        }
    }
}
