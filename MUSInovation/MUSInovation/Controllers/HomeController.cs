using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MUSInovation.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MUSInovation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rechercher(string valeur_recherche = null)
        {
            Movies movies = new Movies();
            if(string.IsNullOrEmpty(valeur_recherche))
                return RedirectToAction("Index");
            var client = new RestClient("http://www.omdbapi.com");
            var request = new RestRequest("/?s=" + valeur_recherche + "&type=Movie&apikey=a0564dcc", Method.GET);
            IRestResponse response = client.Execute(request);
            movies = JsonConvert.DeserializeObject<Movies>(response.Content);
            if (movies.Search.Count == 0)
                movies.Message = "Votre recherche n'a retourné aucun résultat. Cela peut être dû au fait que le titre " +
                    "que vous avez entré ne correspond à aucun film ou qu'il correspond à trop de films pour que nous " +
                    "puissions afficher les résultats.";
            return View(movies);
        }

        public IActionResult AfficherFilm(Movie m)
        {
            return View();
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
