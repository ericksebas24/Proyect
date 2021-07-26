using System.Collections.Generic;
using System.Security.Principal;
using Modelo;
using static Escenario.Escenario;


namespace Escenarios
{
    public interface IEscenario
    {
        public Dictionary<ListaTipo, IEnumerable<IIdentity>> Carga { get; }
    }
}
