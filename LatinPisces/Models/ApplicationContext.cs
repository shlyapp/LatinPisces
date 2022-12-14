using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace LatinPisces.Models
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Card> Cards { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pisces.db");
        }
    }
}
