using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Airport:BaseEntityWithId
    {
        public string AirportName { get; set; }
        public string ICAO { get; set; }
        public string City { get; set; }
    }
}
