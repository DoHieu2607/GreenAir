using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_TicketTypes
{
    public class DetailsModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public DetailsModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        public TicketType TicketType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TicketType = await _context.TicketTypes.FirstOrDefaultAsync(m => m.TicketTypeId == id);

            if (TicketType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
