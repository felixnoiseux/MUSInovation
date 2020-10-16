using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    public class ChuckNorris
    {
        [DataMember(Name = "icon_url", IsRequired = false)]
        public string Icon_url { get; set; }

        [DataMember(Name = "id", IsRequired = false)]
        public string ID { get; set; }

        [DataMember(Name = "url", IsRequired = false)]
        public string Url { get; set; }

        [DataMember(Name = "value", IsRequired = false)]
        public string Value { get; set; }
    }
}
