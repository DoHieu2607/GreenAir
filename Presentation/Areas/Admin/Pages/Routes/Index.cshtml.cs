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
    public class IndexModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public IndexModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        public IList<Route> Route { get;set; }

        public async Task OnGetAsync()
        {
            Route = await _context.Routes
                .Include(r => r.DesAirport)
                .Include(r => r.OrgAirport).ToListAsync();
        }
    }
}
