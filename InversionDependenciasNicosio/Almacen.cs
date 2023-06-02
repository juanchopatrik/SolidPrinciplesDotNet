using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependenciasNicosio
{
    internal class Almacen : IAuditable
    {
        public List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }


        public void AdicionaProducto(Producto pProducto)
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }

        public IEnumerable<Producto> ObtenProductos(int pTipo)
        {
            List<Producto> econtrados = new List<Producto>();

            foreach (Producto p in inventario)
            {
                if (p.Tipo == pTipo)
                {
                    econtrados.Add(p);
                }
            }

            return econtrados; 
        }
    }
}
