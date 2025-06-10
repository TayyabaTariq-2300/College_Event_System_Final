using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using College_Event_System_Final.Models;

namespace College_Event_System_Final.Components.Pages.EventsScaffold
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : PageModel
    {
        private readonly College_Event_System_Final.Models.AppDbContext _context;

        public DeleteModel(College_Event_System_Final.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventData = await _context.Events.FirstOrDefaultAsync(m => m.EventID == id);

            if (eventData == null)
            {
                return NotFound();
            }
            else
            {
                Event = eventData;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var eventData = await _context.Events.FindAsync(id);
            if (eventData != null)
            {
                Event = eventData;
                _context.Events.Remove(Event);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
