using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Providers;

namespace Unidad._5.Lab._1.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioManager _usuarioManager;

        public AccountController(IUsuarioRepository usuarioRepository, IUsuarioManager usuarioManager)
        {
            _usuarioRepository = usuarioRepository;
            _usuarioManager = usuarioManager;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var loggedUser = _usuarioRepository.Validar(loginVM);

            if (loggedUser == null)
            {
                ModelState.AddModelError("", "Mail o contraseña incorrectos");
                return View(loginVM);
            }

            await _usuarioManager.SignIn(this.HttpContext, loggedUser, loginVM.IsPersistent);

            return RedirectToAction("Index", "Materia");
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var loggedUser = _usuarioRepository.Register(registerVM);

            if (loggedUser == null)
            {
                ModelState.AddModelError("", "El usuario ya existe");
                return View(registerVM);
            }

            await _usuarioManager.SignIn(this.HttpContext, loggedUser, registerVM.IsPersistent);

            return RedirectToAction("Index", "Materia");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _usuarioManager.SignOut(this.HttpContext);
            return RedirectToActionPermanent("Index", "Home");
        }
    }
}
