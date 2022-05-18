using Microsoft.AspNetCore.Mvc;
using Payment_Service.Data;
using Payment_Service.Models;
using Payment_Service.Services;

namespace Payment_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("Create")]
        public IActionResult Create(Customer customer)
        {
           var result = _customerService.Create(customer);

           return Ok(result.Id);
        }

        [HttpGet("IsRegistered")]
        public IActionResult IsRegistered(string customerId)
        {
            var result = _customerService.IsRegistered(customerId);

            return Ok(result);
        }
    }
}
