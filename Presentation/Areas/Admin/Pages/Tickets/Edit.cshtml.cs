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

namespace Presentation.Pages_Tickets
{
    public class EditModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public EditModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ticket Ticket { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ticket = await _context.Tickets
                .Include(t => t.Customer)
                .Include(t => t.Flight)
                .Include(t => t.TicketType).FirstOrDefaultAsync(m => m.TicketId == id);

            if (Ticket == null)
            {
                return NotFound();
            }
           ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
           ViewData["FlightId"] = new SelectList(_context.Flights, "FlightId", "FlightId");
           ViewData["TicketTypeId"] = new SelectList(_context.TicketTypes, "TicketTypeId", "TicketTypeId");
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

            _context.Attach(Ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(Ticket.TicketId))
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

        private bool TicketExists(string id)
        {
            return _context.Tickets.Any(e => e.TicketId == id);
        }
    }
}
