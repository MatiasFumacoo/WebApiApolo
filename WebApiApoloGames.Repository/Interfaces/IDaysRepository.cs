using WebApiApoloGames.Repository.Models;

namespace WebApiApoloGames.Repository.Interfaces
{
    public interface IDaysRepository
    {
        Task<List<Day>> GetDaysAsync();
    }
}
