using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirportWeatherAPP.Data;

namespace AirportWeatherAPP.Pages.ObservationCRUD
{
    public class EditModel : PageModel
    {
        private readonly AirportWeatherAPP.Data.AirportWeatherAppContext _context;

        public EditModel(AirportWeatherAPP.Data.AirportWeatherAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Observation Observation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var observation =  await _context.Observations.FirstOrDefaultAsync(m => m.ObservationId == id);
            if (observation == null)
            {
                return NotFound();
            }
            Observation = observation;
           ViewData["OrgId"] = new SelectList(_context.WeatherDataOrgs, "OrgId", "OrgId");
           ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Observation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObservationExists(Observation.ObservationId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ObservationExists(int id)
        {
            return _context.Observations.Any(e => e.ObservationId == id);
        }
    }
}
