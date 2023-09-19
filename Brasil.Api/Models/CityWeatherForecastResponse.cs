namespace Brasil.Api.Models
{
    public class CityWeatherForecastResponse
    {
        public string cidade { get; set; }
        public string estado { get; set; }
        public DateTime atualizado_em { get; set; }
        public IEnumerable<Climate> clima { get; set; }
    }
    public class Climate
    {
        public DateTime data { get; set; }
        public string condicao { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public int indice_uv { get; set; }
        public string condicao_desc { get; set; }
    }

}