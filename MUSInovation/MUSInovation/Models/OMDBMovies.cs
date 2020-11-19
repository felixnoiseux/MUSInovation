using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    public class OMDBMovies
    {
        public List<Movie> Search { get; set; }

        public string Message { get; set; }

        public OMDBMovies()
        {
            Search = new List<Movie>();
        }
    }
}
