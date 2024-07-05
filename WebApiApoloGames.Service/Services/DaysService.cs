using AutoMapper;
using WebApiApoloGames.Repository.Interfaces;
using WebApiApoloGames.Service.DTOs;
using WebApiApoloGames.Service.Interfaces;

namespace WebApiApoloGames.Service.Services
{
    public class DaysService : IDaysService
    {
        private readonly IDaysRepository _daysRepository;
        private readonly IMapper _mapper;

        public DaysService(IDaysRepository daysRepository, IMapper mapper)
        {
            _daysRepository = daysRepository;
            _mapper = mapper;
        }

        public async Task<List<DayDto>> GetDaysAsync()
        {
            return _mapper.Map<List<DayDto>>(await _daysRepository.GetDaysAsync());
        }
    }
}
