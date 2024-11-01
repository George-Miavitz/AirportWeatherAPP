using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.DiegoSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

//Created by Diego Reyes
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

        [HttpDelete("deleteobservation")]
        public async Task<IActionResult> ObservationDelete(int ObservationId)
        {
            var response = await ObservationService.ObservationDelete(ObservationId);
            return Ok(response);
        }

    }
}
