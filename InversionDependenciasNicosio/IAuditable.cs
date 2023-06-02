using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependenciasNicosio
{
    internal interface IAuditable
    {
        IEnumerable<Producto> ObtenProductos(int pTipo);
    }
}
