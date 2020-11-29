using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.AspNetCore.Mvc;
using MUSInovation.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MUSInovation.Controllers
{
    public class FilmController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/Film/AfficherFilm/{id}")]
        public IActionResult AfficherFilm(string id) //ID est imdbID
        {
            return AfficherFilmLogique("http://www.omdbapi.com", "/?i=" + id + "&apikey=a0564dcc", false);
        }

        [HttpGet]
        [Route("/Film/AfficherFilmTMDB/{id}")]
        public IActionResult AfficherFilmTMDB(string id) //ID est imdbID
        {
            return AfficherFilmLogique("https://api.themoviedb.org", $"/3/movie/{id}?api_key=cafc81c187346a6f467555cae2e5ebea", true);
        }

        public IActionResult FilmsRecents()
        {
            var client = new RestClient("https://api.themoviedb.org");
            TMDBMovies tmdbmovies = new TMDBMovies();

            var request = new RestRequest("/3/trending/movie/week?api_key=cafc81c187346a6f467555cae2e5ebea", Method.GET);
            IRestResponse response = client.Execute(request);
            tmdbmovies = JsonConvert.DeserializeObject<TMDBMovies>(response.Content);
            Movies movies = new Movies(tmdbmovies);
            movies.Search = movies.Search.Where(m => m.Year != null).OrderByDescending(m => int.Parse(m.Year)).ToList();

            return View(movies);
        }

        private IActionResult AfficherFilmLogique(string domaine, string requete, bool tmdb)
        {
            IMovie film = null;
            var clientOMDB = new RestClient(domaine);
            var requestOMDB = new RestRequest(requete, Method.GET);
            IRestResponse responseOMDB = clientOMDB.Execute(requestOMDB);
            if (tmdb)
            {
                film = JsonConvert.DeserializeObject<TMDBMovie>(responseOMDB.Content);
                film = TMDBMovies.GetMovie((TMDBMovie)film);
            }
            else
                film = JsonConvert.DeserializeObject<Movie>(responseOMDB.Content);


            if (film.Title == null)
            {
                film = new Movie();
                film.Title = "Erreur";
                film.Plot = "Erreur lors du chargement";
            }
            else
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyBV9wwDiogXHuMkVuQ95NQl6-qe31Bj-p4",
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = film.Title + "trailer";
                searchListRequest.MaxResults = 10;

                var searchListResponse = searchListRequest.Execute();
                List<string> videosID = new List<string>();
                foreach (var searchResult in searchListResponse.Items)
                {
                    if (searchResult.Id.Kind == "youtube#video")
                        videosID.Add(searchResult.Id.VideoId);
                }

                film.YoutubeID = videosID.First();

            }

            return View("AfficherFilm", film);
        }

    }
}
