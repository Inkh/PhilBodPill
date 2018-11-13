using Microsoft.EntityFrameworkCore;
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
    }
}
