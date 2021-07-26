using Modelo;
using System.Collections.Generic;
using System.Security.Principal;

namespace Info
{
    public interface IEntityInfo
    {
        public string Publicar(IIdentity entidad);

        public string Publicar(IEnumerable<IIdentity> lista);
    }
}

