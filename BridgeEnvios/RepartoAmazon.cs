using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeEnvios
{
    class RepartoAmazon : Amazon
    {
        private string _numeroPedido;
        public RepartoAmazon(string idPedido):base(new EnvioEspaña())
        {
            _numeroPedido = idPedido;
        }
        public RepartoAmazon(string idPedido, IEnvio envio) : base(envio)
        {
            _numeroPedido = idPedido;
        }

    }
}
