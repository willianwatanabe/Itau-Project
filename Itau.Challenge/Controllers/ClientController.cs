using Itau.Challenge.Models;
using Itau.Challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Itau.Challenge.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepositoy;

        public ClientController(IClientRepository client)
        {
            _clientRepositoy = client;
        }


        public IActionResult Index()
        {
            var clients = _clientRepositoy.GetAll();
            return View(clients);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(ClientModel client)
        {
            _clientRepositoy.Create(client);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var client = _clientRepositoy.GetById(id);
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(ClientModel client)
        {
            _clientRepositoy.Edit(client);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _clientRepositoy.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult ConfirmDelete(int id)
        {
            var client = _clientRepositoy.GetById(id);
            return View(client);
        }
    }
}
