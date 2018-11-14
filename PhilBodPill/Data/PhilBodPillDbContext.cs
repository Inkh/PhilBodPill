using Microsoft.EntityFrameworkCore;
using PhilBodPill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Data
{
    public class PhilBodPillDbContext : DbContext
    {
        public PhilBodPillDbContext(DbContextOptions<PhilBodPillDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
