using System;
using System.Collections.Generic;

namespace Bridge
{
    interface IBridge
    {
        void MostrarTotales(Dictionary<string,double> pProductos);
        void ListarProdutos(Dictionary<string, double> pProductos);
    }

}
