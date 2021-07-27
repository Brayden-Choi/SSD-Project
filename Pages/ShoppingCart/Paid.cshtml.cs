using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST.Models;

namespace MIST.Pages.ShoppingCart
{
    public class PaidModel : PageModel
    {

        private readonly MIST.Data.MISTDbContext _context;

        public PaidModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }


        public IList<ShoppingCartItem> ShoppingCartItem { get; set; }


        public async Task OnGetAsync()
        {
            ShoppingCartItem = await _context.SCart
            .Include(s => s.Game).ToListAsync();

            foreach (var item in ShoppingCartItem)
            {
                _context.SCart.Remove(item);
            }

            await _context.SaveChangesAsync();
        }
    }
}

