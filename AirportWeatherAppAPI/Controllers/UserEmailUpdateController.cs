using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.TaylorSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserEmailUpdateController : Controller
    {
        private readonly IUserEmailUpdate UserEmailUpdate;
        public UserEmailUpdateController(IUserEmailUpdate useremailupdate)
        {
            this.UserEmailUpdate = useremailupdate;
        }
        [HttpPost("updateemail")]
        public async Task<IActionResult> UpdateEmailAsync(int UserId, string Email)
        {
            if (UserId == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await UserEmailUpdate.UpdateEmail(UserId, Email);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}

