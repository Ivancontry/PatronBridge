using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class CImplementacion3:IBridge
    {
        public void ListarProdutos(Dictionary<string, double> pProductos)
        {
            double total = 0;
            double totalC = 0;
            double totalD = 0;
            double totalM = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                total += p.Value;
                if (p.Key[0] == 'C') totalC += p.Value;
                if (p.Key[0] == 'D') totalD += p.Value;
                if (p.Key[0] == 'M') totalM += p.Value;
                cantidad++;
            }
            Console.WriteLine($"el total de comida es {totalC}, {totalC/total*100}% del total");
            Console.WriteLine($"el total Deportes es {totalD}, {totalD / total * 100}% del total");
            Console.WriteLine($"el total de Medicamentos es {totalM}, {totalM / total * 100}% del total");
            Console.WriteLine($"el total de {cantidad} productos es {total}");
        }

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'C') Console.WriteLine($"Codido: {p.Key} Valor {p.Value}");
            }
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'D') Console.WriteLine($"Codido: {p.Key} Valor {p.Value}");
            }
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (p.Key[0] == 'M') Console.WriteLine($"Codido: {p.Key} Valor {p.Value}");
            }
        }
    }
}
