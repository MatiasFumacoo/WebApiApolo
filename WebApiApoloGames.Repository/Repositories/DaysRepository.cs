using Microsoft.EntityFrameworkCore;
using WebApiApoloGames.Repository.Interfaces;
using WebApiApoloGames.Repository.Models;

namespace WebApiApoloGames.Repository.Repositories
{
    public class DaysRepository : IDaysRepository
    {
        private readonly ApoloGamesContext _apoloGamesContext;

        public DaysRepository(ApoloGamesContext apoloGamesContext)
        {
            _apoloGamesContext = apoloGamesContext;
        }

        public async Task<List<Day>> GetDaysAsync()
        {
            return await _apoloGamesContext.Days.ToListAsync();
        }
    }
}
