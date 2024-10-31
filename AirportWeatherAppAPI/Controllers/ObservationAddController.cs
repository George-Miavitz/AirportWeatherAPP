using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.ShearerSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObservationAddController : ControllerBase
    {
        private readonly IObservationAddClass ObservationAddClass;
        public ObservationAddController(IObservationAddClass observationAddClass)
        {
            this.ObservationAddClass = observationAddClass;
        }

            [HttpPost("addobservation")]
        public async Task<IActionResult> AddObservationAsync(Observation observation)
        {
            if (observation == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await ObservationAddClass.ObservationAdd(observation);
                return Ok(response);
            }
            catch
            {
                return StatusCode(500, "An error occurred while adding the observation.");
            }
        }

    }
}
