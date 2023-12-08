using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using _20___Atividade_CRUD.Context;
using _20___Atividade_CRUD.Models;
using App.Models;

namespace App.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            // Check if there is a user with the provided login and password in the database
            Usuario usuarioAutenticado = _context.Usuarios.FirstOrDefault(u => u.Login == usuario.Login && u.Senha == usuario.Senha);
            if (usuarioAutenticado != null)
            {
                // Set the User Id in the session upon successful authentication
                HttpContext.Session.SetInt32("UsuarioId", usuarioAutenticado.UsuarioId);

                // Successful authentication, redirect to the Admin area
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }
            else
            {
                // Authentication failed, display an error message
                ViewBag.ErrorMessage = "Nome de usuário ou senha incorretos.";
                return View();
            }
        }
    }
}