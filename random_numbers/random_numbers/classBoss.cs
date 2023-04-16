using System;
using Microsoft.EntityFrameworkCore;

namespace Random_numbers
{
	internal class classBoss: DbContext
	{
		public classBoss()
        : base()
        {

				Database.EnsureCreated();
		}

        public virtual DbSet<Numbers>numbers_table{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=numbers_api.db");
    }
	
}

