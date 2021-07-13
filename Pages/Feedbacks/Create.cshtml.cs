using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.Feedbacks
{
    public class CreateModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;

        public CreateModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustRefID"] = new SelectList(_context.Customers, "CustomerID", "CustomerID");
            return Page();
        }

        [BindProperty]
        public Feedback Feedback { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Feedback.Add(Feedback);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
