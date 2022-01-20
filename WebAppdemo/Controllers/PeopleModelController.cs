using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAppdemo.Data;

namespace WebAppdemo.Controllers
{
    public class PeopleModelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeopleModelController(ApplicationDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            List<PeopleModel> list = _context.People.ToList();   
            return View(list);
        }

        public IActionResult CreatePeople()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult CreatePeople(PeopleModel model)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");   
            }

            return View();
        }


    }


}
