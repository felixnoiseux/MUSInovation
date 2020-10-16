using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MUSInovation.Models
{
    [DataContract]
    public class Period
    {
        [DataMember(Name = "number", IsRequired = false)]
        public int Number { get; set; }

        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "startTime", IsRequired = false)]
        public DateTime StartTime { get; set; }

        [DataMember(Name = "endTime", IsRequired = false)]
        public DateTime EndTime { get; set; }

        [DataMember(Name = "isDayTime", IsRequired = true)]
        public bool IsDayTime { get; set; }

        [DataMember(Name = "temperature", IsRequired = true)]
        public int Temperature { get; set; }

        [DataMember(Name = "temperatureUnit", IsRequired = true)]
        public string TemperatureUnit { get; set; }

        [DataMember(Name = "temperatureTrend", IsRequired = false)]
        public string TemperatureTrend { get; set; }

        [DataMember(Name = "windSpeed", IsRequired = true)]
        public string WindSpeed { get; set; }

        [DataMember(Name = "windDirection", IsRequired = true)]
        public string WindDirection { get; set; }

        [DataMember(Name = "icon", IsRequired = true)]
        public string Icon { get; set; }

        [DataMember(Name = "shortForecast", IsRequired = true)]
        public string ShortForecast { get; set; }

        [DataMember(Name = "detailedForecast", IsRequired = true)]
        public string DetailedForecast { get; set; }
    }
}
