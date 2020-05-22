using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21MovieRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21MovieRegistration.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Html5()
        {
            return View();
        }

        public IActionResult DataAno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DataAno(User u)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("UserResult", u);
            }
            else
            {
                return View(u);
            }
        }

        public IActionResult UserResult(User u)
        {
            return View(u);
        }

        public IActionResult ControllerSide()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
