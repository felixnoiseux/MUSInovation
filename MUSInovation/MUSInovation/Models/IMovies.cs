using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    public interface IMovies
    {
        List<IMovie> Search { get; set; }
        string Message { get; set; }
    }
}
