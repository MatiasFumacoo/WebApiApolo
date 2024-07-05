using WebApiApoloGames.Service.DTOs;

namespace WebApiApoloGames.Service.Interfaces
{
    public interface IDaysService
    {
        Task<List<DayDto>> GetDaysAsync();
    }
}
