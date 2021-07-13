using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.Games
{
    [Authorize(Roles = "Admin")]

    public class EditModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext context;
        private readonly IWebHostEnvironment hostingEnvironment;

        public EditModel(MIST.Data.MISTDbContext context, IWebHostEnvironment environment)
        {
            this.hostingEnvironment = environment;
            this.context = context;
        }

        [BindProperty]
        public Game Game { get; set; }

        [BindProperty]
        public IFormFile CoverImage { set; get; }

        [BindProperty]
        public IFormFile Media { set; get; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await context.Game.FirstOrDefaultAsync((System.Linq.Expressions.Expression<Func<Game, bool>>)(m => m.ID == id));

            if (Game == null)
            {
                return NotFound();
            }
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

            if (this.CoverImage != null)
            {
                var fileName = GetUniqueName(this.CoverImage.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, fileName);
                this.CoverImage.CopyTo(new FileStream(filePath, FileMode.Create));
                this.Game.CoverImageName = fileName; // Set the file name
            }

            if (this.Media != null)
            {
                var fileName2 = GetUniqueName(this.Media.FileName);
                var uploads2 = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath2 = Path.Combine(uploads2, fileName2);
                this.Media.CopyTo(new FileStream(filePath2, FileMode.Create));
                this.Game.MediaName = fileName2; // Set the file name
            }

            context.Attach(Game).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(Game.ID))
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

        private bool GameExists(int id)
        {
            return context.Game.Any((System.Linq.Expressions.Expression<Func<Game, bool>>)(e => e.ID == id));
        }

        private string GetUniqueName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                    + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                    + Path.GetExtension(fileName);
        }
    }
}
