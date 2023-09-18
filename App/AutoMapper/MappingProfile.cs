using App.Dto.Airport;
using App.Dto.Cities;
using AutoMapper;
using Domain;


namespace AutoMapper {
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<Airport, AirportResponseDto>();
            CreateMap<CitySearch, CitiesResponseDto>();
            CreateMap<CityRequestDto, CitySearch>();
            
        }
    }
}
