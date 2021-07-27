using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MIST.Data;
using MIST.Models;

//namespace MIST.Pages.ShoppingCart
//{
//    public class CreateModel : PageModel
//    {
//        private readonly MIST.Data.MISTDbContext _context;
//        public CreateModel(MIST.Data.MISTDbContext context)
//        {
//            _context = context;
//        }

        public CreateModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }
        public string UserID { get; set; }
        public string GameID { get; set; }

        public List<ShoppingCartItem> Cart { get; set; }
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
            UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (UserID == null)
            {
                return Redirect("~/");
            }

            GameID = Game.FindFirstValue(ClaimTypes.NameIdentifier);
            if (GameID == null)
            {
                return Redirect("~/");
            }

 /*           //Individul Shopping Cart for Users
            Cart = await _context.SCart
                .Include(c => c.User)
                .Include(c => c.Game)
                .Where(c => c.UserId.Equals(UserID))
                .ToListAsync();
 */
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var cartItem = new ShoppingCartItem
            {
                //ItemId = ShoppingCartItem
                UserId = UserID,
                GameId = Game.Id,
                Quantity = 1;

//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://aka.ms/RazorPagesCRUD.
//        public async Task<IActionResult> OnPostAsync()
//        {
//            if (!ModelState.IsValid)
//            {
//                return Page();
//            }
//            var cartItem = new ShoppingCartItem()
//            {
//                ItemId = ShoppingCartItem
//            }

//            _context.ShoppingCartItem.Add(ShoppingCartItem);
//            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
