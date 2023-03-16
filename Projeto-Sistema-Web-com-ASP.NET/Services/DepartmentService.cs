using Models;
using Projeto_Sistema_Web_com_ASP.NET.Data;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Sistema_Web_com_ASP.NET.Services
{
    public class DepartmentService
    {
        private readonly Projeto_Sistema_Web_com_ASPNETContext _context;

        public DepartmentService(Projeto_Sistema_Web_com_ASPNETContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
