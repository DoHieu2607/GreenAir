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
    public class IndexModel : PageModel
    {
        private readonly Infrastructure.Persistence.GreenairContext _context;

        public IndexModel(Infrastructure.Persistence.GreenairContext context)
        {
            _context = context;
        }

        public IList<Maker> Maker { get;set; }

        public async Task OnGetAsync()
        {
            Maker = await _context.Makers.ToListAsync();
        }
    }
}
