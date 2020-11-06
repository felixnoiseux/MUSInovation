using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    public class Movies
    {
        public List<Movie> Search { get; set; }

        public string Message { get; set; }

        public Movies()
        {
            Search = new List<Movie>();
        }
    }
}
