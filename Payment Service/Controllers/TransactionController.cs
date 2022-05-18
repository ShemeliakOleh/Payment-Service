using Microsoft.AspNetCore.Mvc;
using Payment_Service.Data;
using Payment_Service.Models;
using Payment_Service.Services;

namespace Payment_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : Controller
    {

        private readonly TransactionPowerAppsService _transactionService;
        private readonly TransactionHistoryService _transactionHistoryService;
        public TransactionController(TransactionPowerAppsService transactionService, TransactionHistoryService transactionHistoryService)
        {
            _transactionService = transactionService;
            _transactionHistoryService = transactionHistoryService;
        }

        [HttpPost("Create")]
        public IActionResult Create(TransactionPowerApps transaction)
        {
            var result = _transactionService.Create(transaction);
            return Ok(result);
        }

        [HttpGet("Process")]
        public IActionResult Process(string transactionId)
        {
           var transactionHistory = _transactionService.ProcessTransaction(transactionId);

           transactionHistory = _transactionHistoryService.Create(transactionHistory);

           return Ok(transactionHistory);
        }
    }
}
