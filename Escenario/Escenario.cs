using Modelo;

using System.Collections.Generic;
using System.Security.Principal;

namespace Escenario
{
    public class Escenario
    {
        public enum ListaTipo
        {
            Configuracion,
            Cliente,
            Credito,
            Ingresos,
            TipoCredito,
            VentaVehiculo
        }

        public Dictionary<ListaTipo, IEnumerable<IIdentity>> datos;

        public Escenario()
        {
            datos = new();
        }
    }
}
