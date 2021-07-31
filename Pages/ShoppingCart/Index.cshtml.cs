using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MIST.Data;
using MIST.Models;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace MIST.Pages.ShoppingCart
{
    [Authorize(Roles = "User")]

    public class IndexModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;

        public IndexModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }

        public IList<ShoppingCartItem> ShoppingCartItem { get;set; }
        

        public async Task OnGetAsync()
        {
            var UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            ShoppingCartItem = await _context.SCart
                .Include(s => s.Game)
                .Where(s => s.UserId.Equals(UserID))
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            ShoppingCartItem = await _context.SCart
            .Include(s => s.Game)
            .Where(s => s.UserId.Equals(UserID))
            .ToListAsync();

            if (ShoppingCartItem.Count == 0)
            {
                return RedirectToPage("./Index");
            }
            
            var LineItems = new List<SessionLineItemOptions>();

            foreach (var item in ShoppingCartItem)
                {
                LineItems.Add(new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = Convert.ToInt64(item.Game.Price * 100),
                        Currency = "SGD",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Game.Name,
                        }
                    },
                    Quantity = 1 //item.Quantity,
                }
                );

            }

            var url = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";

            var options = new SessionCreateOptions
            {
                LineItems = LineItems,
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                Mode = "payment",
                SuccessUrl = url+ "/ShoppingCart/Paid",
                CancelUrl = url + "/ShoppingCart/Index",
                BillingAddressCollection = "required"
            };

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
    }
}

