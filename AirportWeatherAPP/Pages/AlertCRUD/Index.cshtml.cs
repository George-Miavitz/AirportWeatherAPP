﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportWeatherAPP.Data;

namespace AirportWeatherAPP.Pages.AlertCRUD
{
    public class IndexModel : PageModel
    {
        private readonly AirportWeatherAPP.Data.AirportWeatherAppContext _context;

        public IndexModel(AirportWeatherAPP.Data.AirportWeatherAppContext context)
        {
            _context = context;
        }

        public IList<Alert> Alert { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Alert = await _context.Alerts
                .Include(a => a.Observation)
                .Include(a => a.User).ToListAsync();
        }
    }
}
