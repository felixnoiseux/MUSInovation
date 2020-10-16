using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    [DataContract]
    public class Properties
    {
        [DataMember(Name = "updated", IsRequired = false)]
        public DateTime Updated { get; set; }

        [DataMember(Name = "units", IsRequired = false)]
        public string Units { get; set; }

        [DataMember(Name = "forecastGenerator", IsRequired = false)]
        public string ForecastGenerator { get; set; }

        [DataMember(Name = "generatedAt", IsRequired = false)]
        public DateTime GeneratedAt { get; set; }

        [DataMember(Name = "updateTime", IsRequired = false)]
        public DateTime UpdateTime { get; set; }

        [DataMember(Name = "validTime", IsRequired = false)]
        public DateTime ValidTime { get; set; }

        [DataMember(Name = "elevation", IsRequired = false)]
        public Elevation Elevation { get; set; }

        [DataMember(Name = "periods", IsRequired = true)]
        public List<Period> Periods { get; set; }

        public string Ville { get; set; }
    }

    [DataContract]
    public class Elevation
    {
        [DataMember(Name = "value", IsRequired = false)]
        public double Value { get; set; }

        [DataMember(Name = "unitCode", IsRequired = false)]
        public string UnitCode { get; set; }
    }
}
