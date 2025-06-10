using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using College_Event_System_Final.Models;

namespace College_Event_System_Final.Components.Pages.RegistrationScaffold
{
    public class DetailsModel : PageModel
    {
        private readonly College_Event_System_Final.Models.AppDbContext _context;

        public DetailsModel(College_Event_System_Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public Registration Registration { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registration = await _context.Registrations.FirstOrDefaultAsync(m => m.RegistrationID == id);
            if (registration == null)
            {
                return NotFound();
            }
            else
            {
                Registration = registration;
            }
            return Page();
        }
    }
}
