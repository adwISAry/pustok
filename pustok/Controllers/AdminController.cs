﻿using Microsoft.AspNetCore.Mvc;

namespace pustok.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
