using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MUSInovation.Controllers
{
    public class ApisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AfficherMeteo()
        {
            return View();
        }
    }
}
