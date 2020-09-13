using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Models.Enums
{
    enum StatusPedido : int
    {
        Fila,
        Preparo,
        Pronto,
        Finalizado
    }
}
