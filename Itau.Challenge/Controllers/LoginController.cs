using Itau.Challenge.Models;
using Itau.Challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Itau.Challenge.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _userRepository;

        public LoginController(IUserRepository user)
        {
            _userRepository = user;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public IActionResult Login(UserModel usuario)
        {
            var user = _userRepository.GetUser(usuario.Login);

            if (user != null && user.isValid(usuario.Password))
                return RedirectToAction("Index", "Client");

            TempData["ErrorMessage"] = "Usuário e/ou senha inválidos.";
            return RedirectToAction("Index");
        }
    }
}
