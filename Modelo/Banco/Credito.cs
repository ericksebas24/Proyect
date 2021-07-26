using System;
using System.Collections.Generic;
using System.Text;


namespace Modelo
{
     public class Credito
    {
        public int IdCredito { get; set; }
        public DateTime fechaCredito { get; set; }
        public int clienteId { get; set; }
        public float valorCredito { get; set; }
        public float pagoInicial { get; set; }
    }
}
