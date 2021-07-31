using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.Feedbacks
{
    [Authorize(Roles = "User")]
    public class CreateModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;

        public CreateModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Feedback Feedback { get; set; }
        public string FeedbackText { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
  
            var UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            _context.Feedback.Add(new Feedback { UserId = UserID , FeedbackText = Feedback.FeedbackText});
            await _context.SaveChangesAsync();

            return Redirect("~/Feedbacks/Submit");
        }

    }
}
