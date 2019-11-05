using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_Planes
{
    public class CreateModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public CreateModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MakerId"] = new SelectList(_context.Makers, "MakerId", "MakerId");
            return Page();
        }

        [BindProperty]
        public Plane Plane { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Planes.Add(Plane);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
