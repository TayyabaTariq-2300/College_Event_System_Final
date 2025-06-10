using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using College_Event_System_Final.Models;

namespace College_Event_System_Final.Components.Pages.FeedbackScaffold
{
    public class CreateModel : PageModel
    {
        private readonly College_Event_System_Final.Models.AppDbContext _context;

        public CreateModel(College_Event_System_Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EventID"] = new SelectList(_context.Events, "EventID", "EventID");
        ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID");
            return Page();
        }

        [BindProperty]
        public Feedback Feedback { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Feedbacks.Add(Feedback);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
