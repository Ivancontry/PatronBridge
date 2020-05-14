using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeEnvios
{
    class EnvioPortugal:IEnvio
    {
        public string Entregar()
        {
            return "Paquete Entregado en Portugal";
        }

        public string Enviar()
        {
            return "Paquete enviado a Portugal";
        }

        public string ProcesarPedido()
        {
            return "Paquete procesado en Portugal";
        }
    }
}
