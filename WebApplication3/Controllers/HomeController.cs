using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;
using WebApplication3.Models.data;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
           this._context = context;
        }

        public IActionResult invoic(int id)
        {
           
            var detalis = _context.details.Where(x => x.Products.idOrder == id);
            return View(detalis);

        }
        public IActionResult Index()
        {
            var service = _context.service.ToList();

            return View(service);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult det(int id)
        {
            var details = _context.details.Where(x => x.Products.idOrder == id);
            return View(details);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}