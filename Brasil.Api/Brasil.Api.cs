using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Brasil.Api
{
    public class BrasilApi
    {
        private static async Task<IRestResponse> BaseApi(string url)
        {
            string BaseUrl = "https://brasilapi.com.br/api/cptec/v1";
            var client = new RestClient(BaseUrl);
            var request = new RestRequest(url, Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteAsync(request);
            return response;
        }


        public static async Task<IRestResponse> ListCity(string cityName)
        {
            string url = $"/cidade/{cityName}";
            return await BaseApi(url);
        }

        public static async Task<IRestResponse> CityWeatherForecast(int cityCode)
        {
            var url = $"/clima/previsao/{cityCode}";

            return await BaseApi(url);
        }

        public static async Task<IRestResponse> AirportWeatherForecast(string icaoCode)
        {
            var url = $"clima/aeroporto/{icaoCode}";

            return await BaseApi(url);
        }

    }

}