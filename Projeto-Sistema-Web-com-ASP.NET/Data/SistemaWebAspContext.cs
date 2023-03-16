using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace SistemaWebAsp.Data
{
    public class SistemaWebAspContext : DbContext
    {
        public SistemaWebAspContext (DbContextOptions<SistemaWebAspContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Department> Department { get; set; }
    }
}
