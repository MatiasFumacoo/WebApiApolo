using AutoMapper;
using WebApiApoloGames.Repository.Models;
using WebApiApoloGames.Service.DTOs;

namespace WebApiApoloGames.Service
{
    public class MappingProfileServices : Profile
    {
        public MappingProfileServices()
        {
            CreateMap<DayDto, Day>();
            CreateMap<Day, DayDto>();
        }
    }
}
