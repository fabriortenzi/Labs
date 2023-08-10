using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess
{
    public class CursosRepositorio
    {
        private readonly IApplicationContextFactory _contextFactory;
        
        public CursosRepositorio(IApplicationContextFactory contextFactory) 
        {
            _contextFactory = contextFactory;
        }

        /// Traer las materias con menos de x horas semanales con el plan z ordenados 
        /// en forma descendente por HsSemanales, incluyendo los datos del plan y la 
        /// especialidad asociados a esta
        public IEnumerable<Materia> GetMaterias(int hsSemanales, int anioPlan)
        {
            using (ApplicationContext context = _contextFactory.CreateContext())
            {
                return context.Materias.Include(x => x.Plan).ThenInclude(x => x.Especialidad)
                    .Where(x => x.HsSemanales < hsSemanales && x.Plan.Anio == anioPlan)
                    .OrderByDescending(x => x.HsSemanales).ToList();
            }
        }

        /// Guardar una materia con el plan mas actual que este asociado con la especialidad
        /// que contenga el nombre parcial enviado como parametro
        public void InsertMateria(Materia materia, string nombreParcialEspecialidad)
        {
            using (ApplicationContext context = _contextFactory.CreateContext())
            {
                var planActual = context.Planes
                    .Where(p => p.Especialidad.Descripcion.Contains(nombreParcialEspecialidad))
                    .OrderByDescending(p => p.Anio)
                    .FirstOrDefault();

                materia.Plan = planActual;

                context.Materias.Add(materia);
                context.SaveChanges();
            }
        }
    }
}
