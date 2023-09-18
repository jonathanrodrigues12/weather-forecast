using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AirportWeatherForecast:BaseEntityWithId
    {
        public string CodeIcao { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AtmosphericPressure { get; set; }
        public string Visibility { get; set; }
        public string Wind { get; set; }
        public int WindDirection { get; set; }
        public int Moisture { get; set; }
        public string Condition { get; set; }
        public string ConditionDesc { get; set; }
        public float Temperature { get; set; }
    }
}
