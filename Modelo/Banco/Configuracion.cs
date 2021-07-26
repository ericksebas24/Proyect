using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Configuracion
    {
        public int ConfiguracionId { get; set; }
        public string NombreEmpresa { get; set; }
        public float MontoMaximo { get; set; }
        public float MontoMinimo { get; set; }
        public int PlazoMaximo { get; set;  }
        public int PlazoMinimo { get; set; }
    }
}
