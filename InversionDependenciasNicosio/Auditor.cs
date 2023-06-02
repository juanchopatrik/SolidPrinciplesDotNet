using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependenciasNicosio
{
    internal class Auditor 
    {
        private IAuditable almacen;

        public Auditor(IAuditable pAlmacen)
        {
            almacen = pAlmacen;
        }

        public double totalesAlimentos()
        {
            double total = 0;

            IEnumerable<Producto> productos = almacen.ObtenProductos(0);

            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto);
                total += producto.Costo;
            }
            return total;
        }
    }
}
