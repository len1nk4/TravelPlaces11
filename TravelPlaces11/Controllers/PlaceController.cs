using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelPLaces11.Data;
using TravelPLaces11.Data.Entities;

namespace TravelPlaces11.Controllers
{
    public class PlaceController : Controller
    {
        private readonly TravelPlaces11DbContext _context;

        public PlaceController(TravelPlaces11DbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var places = await _context.TravelPlaces.ToListAsync();
            return View(places);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TravelPlace place)
        {
            if (!ModelState.IsValid)
            {
                return View(place);
            }

            _context.TravelPlaces.Add(place);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
