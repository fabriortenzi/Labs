using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string> provincias)
        {
            var provinciasQueEmpiezanConSoT = provincias.Where(x => x.StartsWith("S") || x.StartsWith("T"));
            return provinciasQueEmpiezanConSoT;
        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            var numerosMayoresA20 = numeros.Where(x => x > 20);
            return numerosMayoresA20;
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            var codigosPostales = ciudades.Where(x => x.Nombre.ToUpper().Contains(ciudad.ToUpper())).Select(x => x.CodigoPostal);
            return codigosPostales;
        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {
            var empleadosTotales = empleados.Concat(empleadosParaAgregar);

            if (order.ToUpper() == "ASC")
                empleadosTotales = empleadosTotales.OrderBy(x => x.Sueldo);
            else if (order.ToUpper() == "DESC")
                empleadosTotales = empleadosTotales.OrderByDescending(x => x.Sueldo);

            return empleadosTotales;
        }
    }
}
