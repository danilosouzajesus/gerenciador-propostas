using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gerenciador_propostas.Models;

namespace gerenciador_propostas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fornecedores()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Produtos()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Clientes()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Configuracoes()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Propostas()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
