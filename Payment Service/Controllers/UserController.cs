using Microsoft.AspNetCore.Mvc;

namespace Payment_Service.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
