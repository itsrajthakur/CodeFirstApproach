using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext Context)
        {
            _logger = logger;
            context = Context;
        }

        public IActionResult Index()
        {
            var stdData = context.Students.ToList();
            return View(stdData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student data)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(data);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(data);
        }

        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
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
