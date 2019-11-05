using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_Routes
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
        ViewData["Destination"] = new SelectList(_context.Airports, "AirportId", "AirportId");
        ViewData["Origin"] = new SelectList(_context.Airports, "AirportId", "AirportId");
            return Page();
        }

        [BindProperty]
        public Route Route { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Routes.Add(Route);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
