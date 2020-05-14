using System;

namespace BridgeEnvios
{
    class Program
    {
        static void Main(string[] args)
        {
            RepartoAmazon repartoAmazon = new RepartoAmazon("123");
            //Enviamos el pedido a España por defecto
            Console.WriteLine(repartoAmazon.EnviarPedido());
            Console.WriteLine(repartoAmazon.ProcesarPedido());
            Console.WriteLine(repartoAmazon.EntregarPedido());

            Console.ReadLine();

            //Ahora queremos enviar el pedido a Mexico
            repartoAmazon.AsignarEnvio(new EnvioMexico());
            Console.WriteLine(repartoAmazon.EnviarPedido());
            Console.WriteLine(repartoAmazon.ProcesarPedido());
            Console.WriteLine(repartoAmazon.EntregarPedido());

            Console.ReadLine();


        }
    }
}
