using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppdemo.Models;



namespace WebAppdemo.Controllers
{
    public class Game : Controller
    {

        public IActionResult GuessingGame()
        {
            ViewBag.Message = GameUtility.WriteMessage();
            GameUtility game = new GameUtility();

            HttpContext.Session.SetInt32("SessionNumber", game.Random());
            ViewBag.SessionMessage = HttpContext.Session.GetInt32("SessionNumber");

            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int userGuess)
        {
            GameUtility game = new GameUtility();

            if (userGuess == HttpContext.Session.GetInt32("SessionNumber"))
            {
                ViewBag.Message = "You won the number was " + HttpContext.Session.GetInt32("SessionNumber") + ", type in a new numebr to play again";
                HttpContext.Session.SetInt32("SessionNumber", game.Random());
            }
            else if (userGuess > HttpContext.Session.GetInt32("SessionNumber"))
                ViewBag.Message = "Your guess was to high, try again";
            else
            {
                ViewBag.Message = "Your guess was to low, try again";
            }

            return View();
        }

    }
}
