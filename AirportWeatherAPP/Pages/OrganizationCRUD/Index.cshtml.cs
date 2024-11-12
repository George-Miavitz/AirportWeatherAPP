using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportWeatherAPP.Data;

namespace AirportWeatherAPP.Pages.OrganizationCRUD
{
    public class IndexModel : PageModel
    {
        private readonly AirportWeatherAPP.Data.AirportWeatherAppContext _context;

        public IndexModel(AirportWeatherAPP.Data.AirportWeatherAppContext context)
        {
            _context = context;
        }

        public IList<WeatherDataOrg> WeatherDataOrg { get;set; } = default!;

        public async Task OnGetAsync()
        {
            WeatherDataOrg = await _context.WeatherDataOrgs.ToListAsync();
        }
    }
}
