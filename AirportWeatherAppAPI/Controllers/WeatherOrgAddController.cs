using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.ShearerSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherOrgAddController : ControllerBase
    {
        private readonly IWeatherOrgAddClass WeatherOrgAddClass;
        public WeatherOrgAddController(IWeatherOrgAddClass weatherOrgAddClass)
        {
            this.WeatherOrgAddClass = weatherOrgAddClass;
        }

            [HttpPost("addweatherorg")]
        public async Task<IActionResult> AddWeatherOrgAsync(WeatherDataOrg weatherOrg)
        {
            if (weatherOrg == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await WeatherOrgAddClass.WeatherOrgAdd(weatherOrg);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}
