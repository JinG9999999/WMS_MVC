﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMS_MVC.Controllers
{
    public class InventoryrecordController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}