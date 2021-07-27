using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.ShoppingCart
{
    public class EditModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;

        public EditModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ShoppingCartItem ShoppingCartItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShoppingCartItem = await _context.SCart
                .Include(s => s.Game).FirstOrDefaultAsync(m => m.ShoppingCartId == id);

            if (ShoppingCartItem == null)
            {
                return NotFound();
            }
           ViewData["GameId"] = new SelectList(_context.Game, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ShoppingCartItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCartItemExists(ShoppingCartItem.ShoppingCartId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShoppingCartItemExists(int id)
        {
            return _context.SCart.Any(e => e.ShoppingCartId == id);
        }
    }
}
