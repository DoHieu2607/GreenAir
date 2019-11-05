using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_Routes
{
    public class EditModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public EditModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Route Route { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Route = await _context.Routes
                .Include(r => r.DesAirport)
                .Include(r => r.OrgAirport).FirstOrDefaultAsync(m => m.RouteId == id);

            if (Route == null)
            {
                return NotFound();
            }
           ViewData["Destination"] = new SelectList(_context.Airports, "AirportId", "AirportId");
           ViewData["Origin"] = new SelectList(_context.Airports, "AirportId", "AirportId");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Route).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteExists(Route.RouteId))
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

        private bool RouteExists(string id)
        {
            return _context.Routes.Any(e => e.RouteId == id);
        }
    }
}
