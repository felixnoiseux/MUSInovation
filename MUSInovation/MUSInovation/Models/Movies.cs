using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    public class Movies
    {
        public List<IMovie> Search { get; set; }

        public string Message { get; set; }

        public Movies()
        {
            Search = new List<IMovie>();
        }

        public Movies(OMDBMovies omdb) : this()
        {
            Message = omdb.Message;
            foreach (Movie m in omdb.Search)
                Search.Add(m);
        }

        public Movies(TMDBMovies tmdb) : this()
        {
            Message = tmdb.Message;
            foreach (TMDBMovie m in tmdb.Search)
            {
                IMovie m2 = TMDBMovies.GetMovie(m);
                Search.Add(m2);
            }
        }
    }
}
