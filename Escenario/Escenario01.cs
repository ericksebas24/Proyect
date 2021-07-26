using Modelo;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using static Escenario.Escenario;

namespace Escenarios
{
    public class Escenario01 :  Escenario, IEscenario
    {
        public Dictionary<ListaTipo, IEnumerable<IIdentity>> Carga()
        {
            TipoCredito credito = new()
            {
                NombreCredito = "Prestamo Directo",
                interes = 0.04f

            };
            List<TipoCredito> listaCreditos = new() { per2020_PAO2, per2021_PAO1, per2021_PAO2 };
            datos.Add(ListaTipo.TipoCredito, listaCreditos);

            Configuracion configuracion = new()
            {
                NombreEmpresa = "Nissan",
                MontoMaximo = 10.000f,
                MontoMinimo = 5.000f,
                PlazoMaximo = 72,
                PlazoMinimo = 48

            };
            List<Configuracion> listaConfiguracion = new() { configuracion };
            datos.Add(ListaTipo.Configuracion, listaConfiguracion);

        }
    }
}
