﻿using Microsoft.AspNetCore.Mvc;
using Payment_Service.Data;

namespace Payment_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        public DataManager data { get; set; }
        public TransactionController(DataManager dataManager)
        {
            this.data = dataManager;
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
