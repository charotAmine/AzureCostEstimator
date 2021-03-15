using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace costEstimator.Controllers
{
    public class StaticController : Controller
    {
        public IActionResult Documentation()
        {
            return View();
        }
    }
}
