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
    public class ChuckNorrisController : Controller
    {
        public IActionResult Index()
        {

            var client = new RestClient("https://matchilling-chuck-norris-jokes-v1.p.rapidapi.com/jokes/random");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "matchilling-chuck-norris-jokes-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "dbf706d850msh04f7499e1cb3b13p1120d1jsn8966566340f2");
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);

            var chuckNorris = JsonConvert.DeserializeObject<ChuckNorris>(response.Content);

            return View(chuckNorris);
        }
    }
}
