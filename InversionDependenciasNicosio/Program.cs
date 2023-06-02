using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependenciasNicosio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacen miAlmacen = new Almacen();
            double total = 0;

            miAlmacen.AdicionaProducto(new Producto("Tomate", 0, 15.50));
            miAlmacen.AdicionaProducto(new Producto("Banana", 0, 30));
            miAlmacen.AdicionaProducto(new Producto("Analgesico", 1, 23.8 ));
            miAlmacen.AdicionaProducto(new Producto("Jeans", 2 , 450.99 ));
            miAlmacen.AdicionaProducto(new Producto("Manzana", 0, 12.38 ));
            miAlmacen.AdicionaProducto(new Producto("Antiacido", 1, 38.50 ));
            miAlmacen.AdicionaProducto(new Producto("Blusa", 2, 200.88 ));

            Console.WriteLine("------------------");

            Auditor miAuditor = new Auditor(miAlmacen);

            total = miAuditor.totalesAlimentos();

            Console.WriteLine("Total de alimentos: {0}", total);
        }
    }
}
