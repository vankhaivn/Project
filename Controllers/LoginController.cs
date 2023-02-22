using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Project.Controllers {
    public class LoginController : Controller {
        private readonly ILogger<LoginController> _logger;

        public LoginController (ILogger<LoginController> logger) {
            _logger = logger;

        }

        public IActionResult Index () {
            return View("/Views/Login/Index.cshtml");
        }


        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}