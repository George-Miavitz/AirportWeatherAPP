using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AirportWeatherAPP.Data;

namespace AirportWeatherAPP.Pages.ObservationCRUD
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
        ViewData["OrgId"] = new SelectList(_context.WeatherDataOrgs, "OrgId", "OrgId");
        ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return Page();
        }

        [BindProperty]
        public Observation Observation { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Observations.Add(Observation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
