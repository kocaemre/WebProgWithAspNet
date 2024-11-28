using Microsoft.AspNetCore.Mvc;
using WebProgWithAspNet.Data; // ApplicationDbContext i�in gerekli
using System.Linq;

namespace WebProgWithAspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Kalk�� ve var�� bilgilerini veritaban�ndan �ek
            var locations = _context.Flights
                .Select(f => f.DepartureAirport)
                .Distinct()
                .OrderBy(location => location) // A'dan Z'ye s�ralama
                .ToList();


            // Verileri ViewBag ile View'e g�nder
            ViewBag.Locations = locations;
            return View();
        }

        [Route("about-us")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [Route("contact-us")]
        public IActionResult ContactUs()
        {
            return View();
        }


    }
}
