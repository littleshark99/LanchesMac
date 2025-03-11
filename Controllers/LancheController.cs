﻿using LancheMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LancheMac.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {

            ViewData["Titulo"] = "Todos os lanchjes.";
            ViewData["Data"] =DateTime.Now; 


            var lanches = _lancheRepository.Lanche;
            return View(lanches);
        }
    }
}
