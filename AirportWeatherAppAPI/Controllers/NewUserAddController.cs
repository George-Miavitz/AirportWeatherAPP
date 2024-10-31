using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.PhillipSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewUserAddController : Controller
    {
        private readonly INewUserAdd NewUserAddService;
        public NewUserAddController(INewUserAdd newUserAddService)
        {
            this.NewUserAddService = newUserAddService;
        }
        [HttpPost("addnewuser")]
        public async Task<IActionResult> AddUserAsync(User NewUser)
        {
            if (NewUser == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await NewUserAddService.UserAdd(NewUser);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}
