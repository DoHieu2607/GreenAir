using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Presentation.Pages
{
    public class BlogModel : PageModel
    {
        private readonly ILogger<BlogModel> _logger;

        public BlogModel(ILogger<BlogModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
