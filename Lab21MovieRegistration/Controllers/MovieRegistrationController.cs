using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lab21MovieRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21MovieRegistration.Controllers
{
    public class MovieRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieRegistration()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            return View();
        }

        public IActionResult Result(int ID, string Title, string Genre, DateTime Year, string Actors, string Directors)
        {
            ViewBag.ID = ID;
            ViewBag.Title = Title;
            ViewBag.Genre = Genre;
            ViewBag.Year = Year;
            ViewBag.Actors = Actors;
            ViewBag.Directors = Directors;
            return View();  

        }

        public IActionResult Result2(Movie movie)
        {
            return View(movie);
        }


    }
}