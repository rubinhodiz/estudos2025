using Microsoft.AspNetCore.Mvc;

namespace SalesWEBMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
