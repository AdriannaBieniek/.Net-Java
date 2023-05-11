using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Games.Data;
using Games.Games_base;
using Microsoft.Data.SqlClient;

namespace Games.Pages.Games_pages
{
    public class IndexModel : PageModel
    {
        private readonly Games.Data.GamesContext _context;

        public IndexModel(Games.Data.GamesContext context)
        {
            _context = context;
        }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string PriceSort { get; set; }
        public string CurrentFilter { get; set; }


        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            if (_context.Game != null)
            {

                NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                DateSort = sortOrder == "Date" ? "date_desc" : "Date";
                PriceSort = sortOrder == "Price" ? "price_desc" : "Price";

                CurrentFilter = searchString;

                IQueryable<Game> game = from s in _context.Game
                                             select s;

                if (!String.IsNullOrEmpty(searchString))
                {
                    game = game.Where(s => s.Title.ToLower().Contains(searchString.ToLower()));
                }

                switch (sortOrder)
                {
                    case "name_desc":
                        game = game.OrderByDescending(s => s.Title);
                        break;

                    case "Date":
                        game = game.OrderBy(s => s.RelaseDate);
                        break;

                    case "date_desc":
                        game = game.OrderByDescending(s => s.RelaseDate);
                        break;

                    case "Price":
                        game = game.OrderBy(s => s.Price);
                        break;

                    case "price_desc":
                        game = game.OrderByDescending(s => s.Price);
                        break;

                    default:
                        game = game.OrderBy(s => s.Title);
                        break;
                }
                Game = await game.AsNoTracking().ToListAsync();

            }
        }
    }
}
