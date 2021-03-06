﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    [DataContract]
    public class TMDBMovies
    {
        [DataMember(Name = "results", IsRequired = false)]
        public List<TMDBMovie> Search { get; set; }
        public string Message { get; set; }

        public TMDBMovies()
        {
            Search = new List<TMDBMovie>();
        }

        public static IMovie GetMovie(TMDBMovie movie)
        {
            IMovie m = movie;
            if (m.Released == null)
                return null;
            m.Poster = "https://image.tmdb.org/t/p/w185" + m.Poster;
            m.Year = m.Released.Substring(0, 4);
            return m;
        }
    }
}
