using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_sunny28.Models;

namespace Mission6_sunny28.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private MovieContex _movieContext { get; set; }

        public HomeController(MovieContex movie)
        {
            _movieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {

            ViewBag.categories = _movieContext.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(movie);
                _movieContext.SaveChanges();
                return View("Confirmation", movie);
            }
            else
            {
                ViewBag.categories = _movieContext.categories.ToList();
                return View();
            }
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = _movieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Year)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                ViewBag.categories = _movieContext.categories.ToList();

                var movie = _movieContext.responses.Single(x => x.MovieId == id);

                return View("Edit", movie);
            }
            else
            {
                ViewBag.categories = _movieContext.categories.ToList();
                return View();
            }
            
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _movieContext.Update(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _movieContext.responses.Single(x => x.MovieId == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {

            _movieContext.responses.Remove(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");

        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
