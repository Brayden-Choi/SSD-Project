using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.ShoppingCart
{
    public class DeleteModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;

        public DeleteModel(MIST.Data.MISTDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShoppingCartItem = await _context.SCart.FindAsync(id);

            if (ShoppingCartItem != null)
            {
                _context.SCart.Remove(ShoppingCartItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
