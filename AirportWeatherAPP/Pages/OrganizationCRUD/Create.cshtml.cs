﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AirportWeatherAPP.Data;

namespace AirportWeatherAPP.Pages.OrganizationCRUD
{
    public class CreateModel : PageModel
    {
        private readonly AirportWeatherAPP.Data.AirportWeatherAppContext _context;

        public CreateModel(AirportWeatherAPP.Data.AirportWeatherAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WeatherDataOrg WeatherDataOrg { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WeatherDataOrgs.Add(WeatherDataOrg);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}