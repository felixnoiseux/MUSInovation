using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    public class Movies
    {
        public List<Movie> LstMovies { get; set; }

        public Movies()
        {
            LstMovies = new List<Movie>();
        }
    }
}
