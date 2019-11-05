using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Presentation.Pages
{
    public class FlightModel : PageModel
    {
        private readonly ILogger<FlightModel> _logger;

        public FlightModel(ILogger<FlightModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
