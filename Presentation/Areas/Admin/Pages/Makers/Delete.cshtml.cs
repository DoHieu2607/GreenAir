using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_Makers
{
    public class DeleteModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public DeleteModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Maker Maker { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Maker = await _context.Makers.FirstOrDefaultAsync(m => m.MakerId == id);

            if (Maker == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Maker = await _context.Makers.FindAsync(id);

            if (Maker != null)
            {
                _context.Makers.Remove(Maker);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
