using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserTasks.Data;
using UserTasks.Models;

namespace UserTasks.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<User> UserList = _db.Users;
            return View(UserList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}