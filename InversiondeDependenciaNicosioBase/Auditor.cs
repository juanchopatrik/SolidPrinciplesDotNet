using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependenciasNicosioBase
{
    internal class Auditor
    {
        private Almacen almacen;

        public Auditor(Almacen pAlmacen)
        {
            almacen = pAlmacen;
        }

        public double totalesAlimentos()
        {
            double total = 0;
            foreach (Producto p in almacen.Inventario)
            {
                if (p.Tipo == 0)
                    Console.WriteLine(p);
                total += p.Costo;
            }
            return total;
        }
    }
}
