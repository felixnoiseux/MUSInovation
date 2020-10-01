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
    public class FilmController : Controller
    {

        private List<string> titresFilmsRecents = new List<string>()
        {
            "Bloodshot",
            "Artemis Fowl",
            "Invasion",
            "Wonder Woman",
            "Spenser Confidential",
            "Rogue Warfare",
            "Superman",
            "Upside-Down Magic",
            "Mortal Kombat"
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/Film/AfficherFilm/{id}")]
        public IActionResult AfficherFilm(string id) //ID est imdbID
        {
            var client = new RestClient("http://www.omdbapi.com");
            var request = new RestRequest("/?i=" + id + "&apikey=a0564dcc", Method.GET);
            IRestResponse response = client.Execute(request);
            Movie film = new Movie();
            film = JsonConvert.DeserializeObject<Movie>(response.Content);

            if (film.Title == null)
            {
                film = new Movie();
                film.Title = "Erreur";
                film.Plot = "Erreur lors du chargement";
            }

            return View(film);
        }

        public IActionResult FilmsRecents()
        {
            var client = new RestClient("http://www.omdbapi.com");
            Movies movies = new Movies();

            foreach (string titre in titresFilmsRecents)
            {
                var request = new RestRequest("/?t=" + titre + "&y=2020&apikey=a0564dcc", Method.GET);
                IRestResponse response = client.Execute(request);
                Movie film = new Movie();
                film = JsonConvert.DeserializeObject<Movie>(response.Content);

                if (film.Title == null)
                {
                    film = new Movie();
                    film.Title = "Erreur";
                    film.Plot = "Erreur lors du chargement";
                }

                movies.LstMovies.Add(film);
            }

            return View(movies);
        }

    
    }
}
