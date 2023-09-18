using App.Dto.Cities;
using AutoMapper;
using Brasil.Api.Models;
using Brasil.Api;
using Context.Repo;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Util;

namespace App.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ContextApp _context;
        private readonly IMapper _mapper;

        private async Task LogErrors(int statusCode, string JsonContent)
        {
            var error = new Log
            {
                Code = statusCode,
                JsonContent = JsonContent,
                CreatedOn = DateTime.Now
            };
            _context.Add(error);
            _context.SaveChanges();
            throw new ExceptionControlled("Error when searching for information", "Error", "Error when searching for information", true);
        }

        public WeatherForecastController(ContextApp context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet("City/{cityCode}")]
        public async Task<ActionResult<CitiesResponseDto>> City(int cityCode)
        {
            try
            {
                var cityWeatherForecast = BrasilApi.CityWeatherForecast(cityCode).Result;

                if ((int)cityWeatherForecast.StatusCode != 200)
                {
                    LogErrors((int)cityWeatherForecast.StatusCode, cityWeatherForecast.Content);
                }

                var citiesData = JsonConvert.DeserializeObject<CityWeatherForecastResponse>(cityWeatherForecast.Content);

                var city = _context.Cities.Where(o => o.IdBrasilApi == cityCode).FirstOrDefault();
                var cityData = new Cities();
                if (city == null)
                {
                    cityData = new Cities()
                    {
                        Name = citiesData.cidade,
                        State = citiesData.estado,
                        IdBrasilApi = cityCode,
                    };
                    _context.Add(cityData);
                    _context.SaveChanges();
                }


                foreach (var weatherForecastCity in citiesData.clima)
                {
                    var weatherForecastCityItem = new CitiesWeatherForecast()
                    {
                        CitiesId = city != null ? city.Id : cityData.Id,
                        ConditionDescription = weatherForecastCity.condicao_desc,
                        Condition = weatherForecastCity.condicao,
                        Date = weatherForecastCity.data,
                        min = weatherForecastCity.min,
                        max = weatherForecastCity.max,
                        IndexUv = weatherForecastCity.indice_uv,
                    };
                    _context.Add(weatherForecastCityItem);

                }

                _context.SaveChanges();
                var result = new SuccessControlled
                {
                    Status = true,
                    Code = "success",
                    Data = citiesData
                };

                return Ok(result);
            }
            catch (ExceptionControlled ex)
            {

                return BadRequest(ex.ResponseToJson());
            }
            catch (Exception ex)
            {

                return BadRequest(ExceptionControlled.ResponseToJson(ex));
            }

        }



        [AllowAnonymous]
        [HttpGet("Airport/{icaoCode}")]
        public async Task<ActionResult<CitiesResponseDto>> Airport(string icaoCode)
        {
            try
            {
                var airportWeatherForecast = BrasilApi.AirportWeatherForecast(icaoCode).Result;

                if ((int)airportWeatherForecast.StatusCode != 200)
                {
                    LogErrors((int)airportWeatherForecast.StatusCode, airportWeatherForecast.Content);
                }

                var airportData = JsonConvert.DeserializeObject<AirportWeatherForecastResponse>(airportWeatherForecast.Content);

                var airportWeatherForecastData = new AirportWeatherForecast()
                {
                    CodeIcao = airportData.codigo_icao,
                    UpdatedAt = airportData.atualizado_em,
                    AtmosphericPressure = airportData.pressao_atmosferica,
                    Visibility = airportData.visibilidade,
                    Wind = airportData.vento,
                    WindDirection = airportData.direcao_vento,
                    Moisture = airportData.umidade,
                    Condition = airportData.condicao,
                    ConditionDesc = airportData.condicao_Desc,
                    Temperature = airportData.temp

                };
                _context.Add(airportWeatherForecastData);
                _context.SaveChanges();

                var result = new SuccessControlled
                {
                    Status = true,
                    Code = "success",
                    Data = airportData
                };

                return Ok(result);
            }
            catch (ExceptionControlled ex)
            {

                return BadRequest(ex.ResponseToJson());
            }
            catch (Exception ex)
            {

                return BadRequest(ExceptionControlled.ResponseToJson(ex));
            }

        }
    }

}
