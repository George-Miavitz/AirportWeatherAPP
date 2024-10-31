using AirportWeatherAppAPI.ShearerSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AirportWeatherAppAPI.Controllers
{
    public class WeatherOrgAddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
