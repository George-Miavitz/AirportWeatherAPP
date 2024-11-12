using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirportWeatherAPP.Data;

namespace AirportWeatherAPP.Pages.OrganizationCRUD
{
    public class EditModel : PageModel
    {
        private readonly AirportWeatherAPP.Data.AirportWeatherAppContext _context;

        public EditModel(AirportWeatherAPP.Data.AirportWeatherAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WeatherDataOrg WeatherDataOrg { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherdataorg =  await _context.WeatherDataOrgs.FirstOrDefaultAsync(m => m.OrgId == id);
            if (weatherdataorg == null)
            {
                return NotFound();
            }
            WeatherDataOrg = weatherdataorg;
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

            _context.Attach(WeatherDataOrg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeatherDataOrgExists(WeatherDataOrg.OrgId))
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

        private bool WeatherDataOrgExists(int id)
        {
            return _context.WeatherDataOrgs.Any(e => e.OrgId == id);
        }
    }
}
