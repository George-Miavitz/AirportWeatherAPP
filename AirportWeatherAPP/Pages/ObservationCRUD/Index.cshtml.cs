using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportWeatherAPP.Data;

namespace AirportWeatherAPP.Pages.ObservationCRUD
{
    public class IndexModel : PageModel
    {
        private readonly AirportWeatherAPP.Data.AirportWeatherAppContext _context;

        public IndexModel(AirportWeatherAPP.Data.AirportWeatherAppContext context)
        {
            _context = context;
        }

        public IList<Observation> Observation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Observation = await _context.Observations
                .Include(o => o.Org)
                .Include(o => o.User).ToListAsync();
        }
    }
}
