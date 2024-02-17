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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
           
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return View("Confirmation", movie);
            
        }

    }

}
