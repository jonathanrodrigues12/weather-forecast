using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CitiesWeatherForecast: BaseEntityWithId
    {
        [ForeignKey("CitiesId")]
        public Cities Cities { get; set; }
        public long CitiesId { get; set; }
        public DateTime Date { get; set; }
        public string Condition { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public int IndexUv { get; set; }
        public string ConditionDescription { get; set; }

    }
}
