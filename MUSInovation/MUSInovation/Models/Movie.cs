using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    [DataContract]
    public class Movie
    {
        [DataMember(Name = "Title", IsRequired = false)]
        public string Title { get; set; }

        [DataMember(Name = "Year", IsRequired = false)]
        public string Year { get; set; }

        [DataMember(Name = "Rated", IsRequired = false)]
        public string Rated { get; set; }

        [DataMember(Name = "Released", IsRequired = false)]
        public string Released { get; set; }

        [DataMember(Name = "Genre", IsRequired = false)]
        public string Genre { get; set; }

        [DataMember(Name = "Director", IsRequired = false)]
        public string Director { get; set; }

        [DataMember(Name = "Writer", IsRequired = false)]
        public string Writer { get; set; }

        [DataMember(Name = "Actors", IsRequired = false)]
        public string Actors { get; set; }

        [DataMember(Name = "Plot", IsRequired = false)]
        public string Plot { get; set; } //Description

        [DataMember(Name = "Language", IsRequired = false)]
        public string Language { get; set; }

        [DataMember(Name = "Country", IsRequired = false)]
        public string Country { get; set; }

        [DataMember(Name = "Awards", IsRequired = false)]
        public string Awards { get; set; }

        [DataMember(Name = "Poster", IsRequired = false)]
        public string Poster { get; set; }

        [DataMember(Name = "Ratings", IsRequired = false)]
        public IList<Ratings> Ratings { get; set; }

        [DataMember(Name = "Metascore", IsRequired = false)]
        public string Metascore { get; set; }

        [DataMember(Name = "imdbRating", IsRequired = false)]
        public string imdbRating { get; set; }

        [DataMember(Name = "imdbVotes", IsRequired = false)]
        public string imdbVotes { get; set; }

        [DataMember(Name = "imdbID", IsRequired = false)]
        public string imdbID { get; set; }

        [DataMember(Name = "Type", IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "DVD", IsRequired = false)]
        public string DVD { get; set; }

        [DataMember(Name = "BoxOffice", IsRequired = false)]
        public string BoxOffice { get; set; }

        [DataMember(Name = "Production", IsRequired = false)]
        public string Production { get; set; }

        [DataMember(Name = "Website", IsRequired = false)]
        public string Website { get; set; }

        [DataMember(Name = "Response", IsRequired = false)]
        public string Response { get; set; }

    }
}
