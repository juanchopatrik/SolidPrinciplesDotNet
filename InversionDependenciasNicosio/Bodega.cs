using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependenciasNicosio
{
    internal class Bodega : IAuditable
    {
        List<Producto> inventario;

        public Bodega()
        {
            inventario = new List<Producto>();
        }


        public void adicionarProducto(Producto pProducto)
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }

        public IEnumerable<Producto> ObtenProductos(int pTipo)
        {
            List<Producto> products = new List<Producto>();

            foreach (var item in products)
            {
                if (item.Tipo == pTipo)
                {
                    products.Add(item);
                }
            }
            return products;
        }
    }
}
