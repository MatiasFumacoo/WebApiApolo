using Microsoft.AspNetCore.Mvc;
using WebApiApoloGames.Service.Interfaces;

namespace WebApiApoloGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecurityController : ControllerBase
    {
        ISecurityService _securityService;

        public SecurityController(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        [HttpGet]
        public string LoginUser(string userName, string password)
        {
            return _securityService.GetAccessToken(userName, password);
        }
    }
}
