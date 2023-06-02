using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependenciasNicosioBase
{
    internal class Almacen
    {
        public List<Producto> Inventario { get; set; }

        public Almacen()
        {
            Inventario = new List<Producto>();
        }


        public void AdicionaProducto(Producto pProducto)
        {
            Inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }
    }
}
