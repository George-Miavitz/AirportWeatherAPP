using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.TaylorSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserEmailUpddateController : Controller
    {
        private readonly IUserEmailUpdate UserEmailUpdate;
        public UserEmailUpddateController(IUserEmailUpdate useremailupdate)
        {
            this.UserEmailUpdate = useremailupdate;
        }
        [HttpPost("updateemail")]
        public async Task<IActionResult> UpdateEmailAsync(User EmailUpdate)
        {
            if (EmailUpdate == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await UserEmailUpdate.UpdateEmail(EmailUpdate);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}

