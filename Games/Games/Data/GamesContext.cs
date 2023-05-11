using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Games.Games_base;
using Microsoft.Extensions.Options;

namespace Games.Data
{
    public class GamesContext : DbContext
    {
        public GamesContext (DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public DbSet<Games.Games_base.Game> Game { get; set; } = default!;
    }
}
