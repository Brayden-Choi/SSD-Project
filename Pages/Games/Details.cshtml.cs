using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.Games
{
    //[Authorize(Roles = "Admin, User, Staff")]

    public class DetailsModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;

        public DetailsModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync((System.Linq.Expressions.Expression<Func<Game, bool>>)(m => m.ID == id));

            if (Game == null)
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

            var UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _context.SCart.Add(new ShoppingCartItem { UserId = UserID, GameId = (int)id });
            await _context.SaveChangesAsync();

            return Redirect("~/ShoppingCart/Index");
        }
    }
}
