﻿using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() { return View(); }
        public IActionResult Edit() { return View(); }
        public IActionResult Delete() { return View(); }

    }
}
