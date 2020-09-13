using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services.Exception
{
    public class NotFoundException :ApplicationException
    {
        public NotFoundException(string message) : base(message)
        { 
        }
        //exception personalizada
    }
}
