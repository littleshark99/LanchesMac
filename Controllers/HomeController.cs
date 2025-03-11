using System.Diagnostics;
using LancheMac.Models;
using Microsoft.AspNetCore.Mvc;

namespace LancheMac.Controllers
{
    public class HomeController : Controller
    {      
        public IActionResult Index()
        {
            TempData["Nome"] = "marconi";
            return View();
        }      
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
