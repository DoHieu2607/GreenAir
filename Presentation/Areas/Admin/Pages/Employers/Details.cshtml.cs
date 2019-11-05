using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_Employers
{
    public class DetailsModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public DetailsModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        public Employer Employer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employer = await _context.Employers
                .Include(e => e.Job).FirstOrDefaultAsync(m => m.Id == id);

            if (Employer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
