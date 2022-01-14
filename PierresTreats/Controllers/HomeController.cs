using Microsoft.AspNetCore.Mvc;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
