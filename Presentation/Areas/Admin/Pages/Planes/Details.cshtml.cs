using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_Planes
{
    public class DetailsModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public DetailsModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        public Plane Plane { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plane = await _context.Planes
                .Include(p => p.Maker).FirstOrDefaultAsync(m => m.PlaneId == id);

            if (Plane == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
