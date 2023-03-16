using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Projeto_Sistema_Web_com_ASP.NET.Models;

namespace Projeto_Sistema_Web_com_ASP.NET.Data
{
    public class Projeto_Sistema_Web_com_ASPNETContext : DbContext
    {
        public Projeto_Sistema_Web_com_ASPNETContext (DbContextOptions<Projeto_Sistema_Web_com_ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
