using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace Presentation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Flight_type{ get; set; }
        [BindProperty]
        public string Checkin_date{ get; set; }
        [BindProperty]
        public string Checkout_date { get; set; }

        public string Msg { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
        // public IActionResult OnPostFlightSearch()
        // {
        //     if(Flight_type.Equals("round"))
        //     {
        //         if(Checkout_date != null )
        //         {
        //             HttpContext.Session.SetString("checkin_date", Checkin_date);
        //             HttpContext.Session.SetString("checkout_date", Checkout_date); 
        //             return RedirectToPage("Flight");    
        //         }
        //         else
        //         {
        //             Msg = "Please choose check out date";
        //             return Page();            
        //         }
                
        //     }
        //     if(Flight_type.Equals("one"))
        //     {
        //         HttpContext.Session.SetString("checkin_date",Checkin_date);
        //         return RedirectToPage("Flight");
        //     }
            
        // }
    }
}
