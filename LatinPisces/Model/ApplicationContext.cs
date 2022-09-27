using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using LatinPisces.Model;

namespace LatinPisces.Model
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        {

        }
    } 
}
