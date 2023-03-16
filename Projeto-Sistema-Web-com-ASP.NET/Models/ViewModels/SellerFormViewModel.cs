using Models;
using System.Collections.Generic;

namespace Projeto_Sistema_Web_com_ASP.NET.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
