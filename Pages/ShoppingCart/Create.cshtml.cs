using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.ShoppingCart
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
        ViewData["GameId"] = new SelectList(_context.Game, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public ShoppingCartItem ShoppingCartItem { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ShoppingCartItem.Add(ShoppingCartItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
