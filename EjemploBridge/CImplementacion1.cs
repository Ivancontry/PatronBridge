using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploBridge
{
    class CImplementacion1 : IBridge
    {
        public void ListarProdutos(Dictionary<string, double> pProductos)
        {
            double total = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string, double> p in pProductos) {
                total += p.Value;
                cantidad++;
            }
            Console.WriteLine($"el total de {cantidad} productos es {total}");
        }

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                Console.WriteLine(p.Value);
            }
        }
    }
}
