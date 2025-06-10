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
    public class IndexModel : PageModel
    {
        private readonly College_Event_System_Final.Models.AppDbContext _context;

        public IndexModel(College_Event_System_Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Registration = await _context.Registrations
                .Include(r => r.Event)
                .Include(r => r.User).ToListAsync();
        }
    }
}
