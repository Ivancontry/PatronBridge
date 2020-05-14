using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeEnvios
{
    class EnvioMexico : IEnvio
    {
        public string Entregar()
        {
            return "Paquete Entregado en Mexico";
        }

        public string Enviar()
        {
            return "Paquete enviado a Mexico";
        }

        public string ProcesarPedido()
        {
            return "Paquete procesado en Mexico";
        }
    }
}
