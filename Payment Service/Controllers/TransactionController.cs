﻿using Microsoft.AspNetCore.Mvc;

namespace Payment_Service.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
