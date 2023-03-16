using Projeto_Sistema_Web_com_ASP.NET.Data;
using Projeto_Sistema_Web_com_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Sistema_Web_com_ASP.NET.Services
{
    public class SellerService
    {
        private readonly Projeto_Sistema_Web_com_ASPNETContext _context;

        public SellerService(Projeto_Sistema_Web_com_ASPNETContext context)
        {
            _context = context;
        }

        public List<Seller> FildAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
