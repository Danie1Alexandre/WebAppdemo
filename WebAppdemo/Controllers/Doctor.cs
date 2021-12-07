using Microsoft.AspNetCore.Mvc;
using WebAppdemo.Models;

namespace WebAppdemo.Controllers
{
    public class Doctor : Controller
    {
        public IActionResult FeverCheck() 
        {
            ViewBag.Message = thermometer.WriteMessage();
            return View(); 
        }

        [HttpPost]
        public IActionResult FeverCheck(int value)
        {
            thermometer temp = new thermometer();

            ViewBag.Message = temp.WriteMessage(value);

            return View();
        }

    }
}
