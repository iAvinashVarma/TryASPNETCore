using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TryASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			return View(Model.Character.GetAll());
        }

		public IActionResult Create(string characterName)
		{
			Model.Character.Create(characterName);
			return RedirectToAction("Index");
		}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
