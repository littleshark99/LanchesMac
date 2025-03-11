using LancheMac.Repositories.Interfaces;
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

            var lanches = _lancheRepository.Lanche;
            var totalLanches = lanches.Count();

            ViewBag.Total = "Total de lanches : ";
            ViewBag.TotalLanches = totalLanches;




            return View(lanches);
        }
    }
}
