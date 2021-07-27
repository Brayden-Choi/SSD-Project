using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MIST.Data;
using MIST.Models;

namespace MIST.Pages.Games
{
   // [Authorize(Roles = "Admin, User, Staff")]

    public class IndexModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;

        public IndexModel(MIST.Data.MISTDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Game
                orderby m.Genre
                select m.Genre;

            var games = from m in _context.Game
                select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                games = games.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(Genre))
            {
                games = games.Where(x => x.Genre == Genre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Game = await games.ToListAsync();
        }
    }
}
