using Microsoft.AspNetCore.Mvc;
using Payment_Service.Data;
using Payment_Service.Models;

namespace Payment_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        public DataManager data { get; set; }

        public CustomerController(DataManager dataManager)
        {
            this.data = dataManager;
        }

      
        [HttpGet("Create")]
        public IActionResult Create()
        {
           
            return Ok();
        }
    }
}
