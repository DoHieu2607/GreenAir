using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_Routes
{
    public class DetailsModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public DetailsModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
