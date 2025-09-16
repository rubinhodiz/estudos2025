using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesWEBMVC.Models;

namespace SalesWEBMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Mensagem"] = "Sistema de estudos C#";
            ViewData["Aluno"] = "Robson César Diniz";
            return View();
        }

        public IActionResult Privacy()

        {
            ViewData["mensagem"] = "Rubinho Diniz";
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
