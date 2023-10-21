using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AlumnoNegocio
    {
        static readonly string defaultURL = "https://localhost:7002/api/Alumno/";

        public async static Task<IEnumerable<Alumno>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<Alumno>>(response);
            return data;
        }

        public async static Task<bool> Delete(Alumno alumno)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + alumno.DNI);
            return response.IsSuccessStatusCode;
        }

        public async static Task<bool> Add(Alumno alumno)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, alumno);
            return response.IsSuccessStatusCode;
        }

        public async static Task<bool> Update(Alumno alumno)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + alumno.DNI, alumno);
            return response.IsSuccessStatusCode;
        }
    }
}
