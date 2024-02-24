using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Costley.Models;
using System.Diagnostics;

namespace Mission06_Costley.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();

                return View("Confirmation", movie);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(movie);
            }
        }

        public IActionResult WaitList()
        {
            //var movieList = _context.Movies
            //    .Include(m => m.CategoryName) // Include the CategoryName navigation property
            //    .ToList()
            //    .OrderBy(x => x.Title)
            //    .ToList();

            //return View(movieList);
            var movieList = _context.Movies.Include("CategoryName").ToList()
                  .OrderBy(x => x.Title).ToList();

            return View(movieList);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]

        public IActionResult Edit(Movie updatedInfo) 
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("WaitList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("WaitList");
        }
    }

}
