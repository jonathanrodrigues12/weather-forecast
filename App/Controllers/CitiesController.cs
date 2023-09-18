using App.Dto.Cities;
using AutoMapper;
using Brasil.Api;
using Brasil.Api.Models;
using Context.Repo;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp.Serialization.Json;
using Util;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ContextApp _context;
        private readonly IMapper _mapper;

        public CitiesController(ContextApp context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet("{cityName}")]
        public async Task<ActionResult<CitiesResponseDto>> City(string cityName)
        {
            try
            {
                var cities = BrasilApi.ListCity(cityName).Result;

                if ((int)cities.StatusCode != 200)
                {
                    var error = new Log
                    {
                        Code = (int)cities.StatusCode,
                        JsonContent = cities.Content,
                        CreatedOn = DateTime.Now
                    };
                    _context.Add(error);
                    _context.SaveChanges();
                    throw new ExceptionControlled("Error when searching for information","Error","Error when searching for information",true);
                }

                var citiesData = JsonConvert.DeserializeObject<IEnumerable<CitiesResponse>>(cities.Content);

                foreach (var city in citiesData)
                {
                    var cityItem = new CityRequestDto()
                    {
                        Name = city.nome,
                        State = city.estado
                    };

                    var cityMapped = _mapper.Map<CityRequestDto, CitySearch>(cityItem);

                    _context.Add(cityMapped);
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
    }
}
