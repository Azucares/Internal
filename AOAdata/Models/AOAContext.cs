using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOAdata.Models
{
    public class AOAContext : DbContext
    {
        public AOAContext(DbContextOptions<AOAContext> opts) : base(opts) { }

        public DbSet<Part> Parts { get; set; }
        public DbSet<PartsInventory> PartsInventory { get; set; }
    }
}
