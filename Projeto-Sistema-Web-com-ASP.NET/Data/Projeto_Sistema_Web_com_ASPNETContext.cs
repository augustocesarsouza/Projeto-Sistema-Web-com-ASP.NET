using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Projeto_Sistema_Web_com_ASP.NET.Data
{
    public class Projeto_Sistema_Web_com_ASPNETContext : DbContext
    {
        public Projeto_Sistema_Web_com_ASPNETContext (DbContextOptions<Projeto_Sistema_Web_com_ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Department> Department { get; set; }
    }
}
