using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bertozzi.mattia._5H.PrimaWeb.Models;

namespace bertozzi.mattia._5H.PrimaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Persone()
        {
            List<Persona> p = new List<Persona>();

            p.Add(new Persona{Id=1,Nome="mattia",Cognome="Bertozzi",Email="Mattia.bertozzi@gmail.com"});
            p.Add(new Persona{Id=2,Nome="Gaia",Cognome="Amati",Email="Gaia.Amati@gmail.com"});

            return View(p);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
