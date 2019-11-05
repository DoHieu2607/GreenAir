using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Presentation.Pages_FlightDetails
{
    public class IndexModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public IndexModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        public IList<FlightDetail> FlightDetail { get;set; }

        public async Task OnGetAsync()
        {
            FlightDetail = await _context.FlightDetails
                .Include(f => f.Flight)
                .Include(f => f.Route).ToListAsync();
        }
    }
}
