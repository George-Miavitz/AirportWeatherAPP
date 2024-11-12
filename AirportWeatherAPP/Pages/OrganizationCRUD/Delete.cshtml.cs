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
    public class DeleteModel : PageModel
    {
        private readonly AirportWeatherAPP.Data.AirportWeatherAppContext _context;

        public DeleteModel(AirportWeatherAPP.Data.AirportWeatherAppContext context)
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

            var weatherdataorg = await _context.WeatherDataOrgs.FirstOrDefaultAsync(m => m.OrgId == id);

            if (weatherdataorg == null)
            {
                return NotFound();
            }
            else
            {
                WeatherDataOrg = weatherdataorg;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherdataorg = await _context.WeatherDataOrgs.FindAsync(id);
            if (weatherdataorg != null)
            {
                WeatherDataOrg = weatherdataorg;
                _context.WeatherDataOrgs.Remove(WeatherDataOrg);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
