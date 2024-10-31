
using Microsoft.AspNetCore.Mvc;
using AirportWeatherAppAPI.PhillipSPRepositories;
using AirportWeatherAppAPI.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AirportWeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteOrgController : Controller
    {
        private readonly IDeleteOrgService DeleteOrgService;
        public DeleteOrgController(IDeleteOrgService DeleteOrgService)
        {
            this.DeleteOrgService = DeleteOrgService;
        }
        [HttpDelete("deleteorg")]

        public async Task<IActionResult> OrgDelete(int OrgId)
        {
            var response = await DeleteOrgService.DeleteOrg(OrgId);
            return Ok(response);
        }
        
          
    }
}

