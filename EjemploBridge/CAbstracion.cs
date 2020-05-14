using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploBridge
{
    //Esta clase conecta al cliente con la implementacion a utilizar
    class CAbstracion
    {
        //Referencia a la implementación
        IBridge implementacion;
        Dictionary<string, double> productos;
        public CAbstracion(IBridge implementacion, Dictionary<string,double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }

        public void MostrarTotales() {
            implementacion.MostrarTotales(productos);
        }

        public void ListarProductos() {
            implementacion.ListarProdutos(productos);
        }
    }
}
