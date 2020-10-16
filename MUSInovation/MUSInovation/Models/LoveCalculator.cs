using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    public class LoveCalculator
    {
        [DataMember(Name = "fname", IsRequired = false)]
        public string FirstName { get; set; }


        [DataMember(Name = "sname", IsRequired = false)]
        public string SecondName { get; set; }


        [DataMember(Name = "percentage", IsRequired = false)]
        public string Percentage { get; set; }


        [DataMember(Name = "result", IsRequired = false)]
        public string Result { get; set; }
    }
}
