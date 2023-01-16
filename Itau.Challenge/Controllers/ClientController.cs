using Itau.Challenge.Models;
using Itau.Challenge.Repository.Interfaces;
using Itau.Challenge.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace Itau.Challenge.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepositoy;
        private readonly IValidationService _validationService;

        public ClientController(IClientRepository client, IValidationService validation)
        {
            _clientRepositoy = client;
            _validationService = validation;
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
            var cpf = _validationService.IsCpf(client.Cpf);
            if (cpf.Item1)
            {
                client.Cpf = cpf.Item2;
                _clientRepositoy.Create(client);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Register");
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

        public IActionResult Details(int id)
        {
            var client = _clientRepositoy.GetById(id);
            return View(client);
        }
    }
}
