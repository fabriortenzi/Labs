using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers
{
    public class MateriaController : Controller
    {
        private readonly ILogger<MateriaController> _logger;
        private readonly IMateriaRepository _materiaRepository;
        private readonly IPlanRepository _planRepository;

        public MateriaController(ILogger<MateriaController> logger, IMateriaRepository materiaRepository, IPlanRepository planRepository)
        {
            _logger = logger;
            _materiaRepository = materiaRepository;
            _planRepository = planRepository;
            _logger.LogDebug("Inicializado controlador MateriaController");
        }

        public IActionResult Index() => RedirectToAction("List");

        public IActionResult List()
        {
            return View(_materiaRepository.GetAll());
        }

        [HttpGet] // Es opcional declarar esta anotacion
        [Authorize(Roles = "Admin, Superadmin")]
        public IActionResult Edit(int? id)
        {
            if (id.HasValue == false)
            {
                return NotFound();
            }
            
            var materia = _materiaRepository.GetOne((int) id);                
            if (materia == null)
            {
                return NotFound();
            }

            return View(new EditMateriaViewModel(materia, _planRepository.GetAll()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Superadmin")]
        public IActionResult Edit(int id, [Bind("Id, Descripcion, HsSemanales, HsTotales, PlanId")]Materia materia)
        {
            if (id != materia.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(new EditMateriaViewModel(materia, _planRepository.GetAll()));
            }

            _materiaRepository.Update(materia);
            return RedirectToAction("List", "Materia");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View(new CreateMateriaViewModel(null, _planRepository.GetAll()));
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Descripcion, HsSemanales, HsTotales, PlanId")] Materia materia)
        {
            if (!ModelState.IsValid)
            {
                return View(new EditMateriaViewModel(materia, _planRepository.GetAll()));
            }

            _materiaRepository.Add(materia);
            return RedirectToAction("List", "Materia");
        }

        [HttpGet]
        [Authorize(Roles = "Superadmin")]
        public IActionResult Delete(int? id)
        {
            if (id.HasValue == false)
            {
                return NotFound();
            }

            var materia = _materiaRepository.GetOne((int) id);
            if (materia == null)
            {
                return NotFound();
            }

            return View(materia);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Superadmin")]
        public IActionResult DeleteConfirmed(int id)
        {
            var materia = _materiaRepository.Delete(id);

            if (materia == null) return NotFound();

            return RedirectToAction("List");
        }
    }
}