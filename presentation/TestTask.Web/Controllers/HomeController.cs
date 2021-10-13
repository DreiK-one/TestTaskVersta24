using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using TestTask.EF;
using TestTask.Web.Models;

namespace TestTask.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestTaskContext db;

        public HomeController(TestTaskContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Orders.ToList());
        }

        [HttpGet]
        public IActionResult Buy()
        {
            return View();
        }

        public IActionResult Buy(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return View("Thx");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Thx()
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
