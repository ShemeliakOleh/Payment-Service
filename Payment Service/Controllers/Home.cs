using Microsoft.AspNetCore.Mvc;
using Payment_Service.Data;
using Payment_Service.Models;
using Payment_Service.Services;

namespace Payment_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Home : Controller
    {

        [HttpGet("Index")]
        public IActionResult Index()
        {

            return Ok();
        }

    }
}
