using System;

namespace Projeto_Sistema_Web_com_ASP.NET.Services.Excepetion
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
