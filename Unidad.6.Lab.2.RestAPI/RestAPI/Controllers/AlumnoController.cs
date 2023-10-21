using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Context;
using RestAPI.Models;


namespace RestAPI.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly MyDbContext _context;

        public AlumnoController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/Alumno/")]
        public ActionResult<IEnumerable<Alumno>> GetAll()
        {
            return _context.Alumnos.OrderBy(a => a.DNI).ToList();
        }

        [HttpGet("/api/Alumno/{DNI}")]
        public ActionResult<Alumno> GetById(string DNI)
        {
            var alumno = _context.Alumnos.Find(DNI);
            if (alumno == null)
            {
                return NotFound();
            }
            return alumno;
        }

        [HttpPost("/api/Alumno/")]
        public ActionResult<Alumno> Create([FromBody] Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { DNI = alumno.DNI }, alumno);
        }

        [HttpPut("/api/Alumno/{DNI}")]
        public ActionResult Update(string DNI, [FromBody] Alumno alumno)
        {
            if (DNI != alumno.DNI)
            {
                return BadRequest();
            }
            _context.Entry(alumno).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("/api/Alumno/{DNI}")]
        public async Task<ActionResult<Alumno>> Delete(string DNI)
        {
            var alumno = _context.Alumnos.Find(DNI);
            if (alumno == null)
            {
                return NotFound();
            }
            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();
            return alumno;
        }
    }
}
