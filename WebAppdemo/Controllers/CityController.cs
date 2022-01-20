using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAppdemo.Data;

namespace WebAppdemo.Controllers
{
    public class CityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {            
            List<CityModel> list = _context.City.ToList();
            return View(list);
        }

 
    }
}
