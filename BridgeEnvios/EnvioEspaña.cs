using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeEnvios
{
    class EnvioEspaña : IEnvio
    {
        public string Entregar()
        {
           return "Paquete Entregado en España";
        }

        public string Enviar()
        {
            return "Paquete enviado a España";
        }

        public string ProcesarPedido()
        {
            return "Paquete procesado en España";
        }
    }
}
