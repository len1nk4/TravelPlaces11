using Microsoft.AspNetCore.Mvc;

namespace TravelPlaces11.Controllers
{
    public class PlaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
