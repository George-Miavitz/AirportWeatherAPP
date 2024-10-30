using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.DiegoSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObservationController : Controller
    {
        private readonly IObservationService ObservationService;
        public ObservationController(IObservationService observationService)
        {
            this.ObservationService = observationService;
        }

        [HttpDelete("deletevehicle")]
        public async Task<IActionResult> ObservationDelete(int ObservationID)
        {
            var response = await ObservationService.ObservationDelete(ObservationID);
            return Ok(response);
        }

    }
}
