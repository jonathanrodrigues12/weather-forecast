using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasil.Api.Models
{
    public class AirportWeatherForecastResponse
    {
        public string codigo_icao { get; set; }
        public DateTime atualizado_em { get; set; }
        public int pressao_atmosferica { get; set; }
        public string visibilidade { get; set; }
        public string vento { get; set; }
        public int direcao_vento { get; set; }
        public int umidade { get; set; }
        public string condicao { get; set; }
        public string condicao_Desc { get; set; }
        public float temp { get; set; }
    }
}
