using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    [DataContract]
    public class TMDBMovie : IMovie
    {
        [DataMember(Name = "title", IsRequired = false)]
        public string Title { get ; set ; }
        public string Year { get ; set ; }
        public string Rated { get ; set ; }
        [DataMember(Name = "release_date", IsRequired = false)]
        public string Released { get ; set ; }
        public string Genre { get ; set ; }
        public string Director { get ; set ; }
        public string Writer { get ; set ; }
        public string Actors { get ; set ; }
        [DataMember(Name = "overview", IsRequired = false)]
        public string Plot { get ; set ; }
        public string Language { get ; set ; }
        public string Country { get ; set ; }
        public string Awards { get ; set ; }
        [DataMember(Name = "poster_path", IsRequired = false)]
        public string Poster { get ; set ; }
        public IList<Ratings> Ratings { get ; set ; }
        public string Metascore { get ; set ; }
        [DataMember(Name = "vote_average", IsRequired = false)]
        public string imdbRating { get ; set ; }
        public string imdbVotes { get ; set ; }
        [DataMember(Name = "id", IsRequired = false)]
        public string imdbID { get ; set ; }
        public string Type { get ; set ; }
        public string DVD { get ; set ; }
        public string BoxOffice { get ; set ; }
        public string Production { get ; set ; }
        public string Website { get ; set ; }
        public string Response { get ; set ; }
        public string YoutubeID { get ; set ; }
    }
}
