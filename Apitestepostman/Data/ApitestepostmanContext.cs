using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apitestepostman.Models;

namespace Apitestepostman.Data
{
    public class ApitestepostmanContext : DbContext
    {
        public ApitestepostmanContext (DbContextOptions<ApitestepostmanContext> options)
            : base(options)
        {
        }

        public DbSet<Apitestepostman.Models.Produto> Produto { get; set; }
    }
}
