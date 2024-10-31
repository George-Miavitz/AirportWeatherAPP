using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.DiegoSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertController : Controller
    {
        private readonly IAlertService AlertService;
        public AlertController(IAlertService alertService)
        {
            this.AlertService = alertService;   
        }
        [HttpPost("addalert")]
        public async Task<IActionResult> AddAlertAsync(Alert NewAlert)
        {
            if (NewAlert == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await AlertService.AlertAdd(NewAlert);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}
