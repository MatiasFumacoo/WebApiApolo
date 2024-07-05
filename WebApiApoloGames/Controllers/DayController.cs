using Microsoft.AspNetCore.Mvc;
using WebApiApoloGames.Service.DTOs;
using WebApiApoloGames.Service.Interfaces;

namespace WebApiApoloGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DayController : ControllerBase
    {
        private readonly IDaysService _daysService;

        public DayController(IDaysService daysService)
        {
            _daysService = daysService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DayDto>>> GetDays()
        {
            return await _daysService.GetDaysAsync();
        }
    }
}
