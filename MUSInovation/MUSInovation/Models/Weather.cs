using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    [DataContract]
    public class Weather
    {
        [DataMember(Name = "type", IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "properties", IsRequired = true)]
        public Properties Properties { get; set; }
    }
}
