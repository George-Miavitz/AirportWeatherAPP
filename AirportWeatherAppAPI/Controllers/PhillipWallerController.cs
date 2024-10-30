/*
using AirportWeatherAppAPI;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AirportWeatherAppAPI.Controllers
{
    public class PhillipWallerController : ControllerBase
    {
        private readonly IPhillipWaller PhillipWaller;
        public PhillipWallerController(IPhillipWaller phillipWaller)
        {
            this.PhillipWaller = phillipWaller;
        }
        [HttpPost("UserAddGetByUsername")]
        public async Task<IActionResult> UserAddGetByUsernameAsync(AirportWeatherAppAPI user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await AirportWeatherAppAPI.UserAddGetByUsername(user);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}
*/