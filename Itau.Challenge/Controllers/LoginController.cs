using Itau.Challenge.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Itau.Challenge.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserModel login)
        {
            //if (login.IsValid(login))
            //{
            //    //_notyf.Error("Preencha todos os campos corretamente!");
            //    return View(login);
            //}

            //var usuarioParaLogin = await _autorizacaoService.VerificarSeUsuarioEstaAutorizado(login.Chave, login.Senha);
            //if (!usuarioParaLogin.Valido)
            //{
            //    _notyf.Error(usuarioParaLogin.Mensagem);
            //    return View(login);
            //}

            //await AutenticacaoHelper.AutenticarNoCookie(login.Chave, usuarioParaLogin, false, HttpContext);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
