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
    public class LoveCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Resultat()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Resultat(string premier_nom, string deuxieme_nom)
        {
            if (premier_nom == null)
                premier_nom = "default";
            else if (deuxieme_nom == null)
                deuxieme_nom = "default";

            var client = new RestClient("https://rapidapi.p.rapidapi.com/getPercentage?fname=" + premier_nom + "&sname=" + deuxieme_nom);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "love-calculator.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "dbf706d850msh04f7499e1cb3b13p1120d1jsn8966566340f2");
            IRestResponse response = client.Execute(request);
            var loveCalculator = JsonConvert.DeserializeObject<LoveCalculator>(response.Content);

            loveCalculator.FirstName = premier_nom;
            loveCalculator.SecondName = deuxieme_nom;

            return View(loveCalculator);
        }
    }
}
