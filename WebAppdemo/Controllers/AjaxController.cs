using Microsoft.AspNetCore.Mvc;
using WebAppdemo.Models;
using System;
using System.Collections.Generic;

namespace WebAppdemo.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            PeopleController peopleController = new PeopleController();
            peopleController.People();
            return View();
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            PersonData personData = new PersonData();
            List<Person> personList = personData.Read(); 
            return PartialView("_PeopleListPartial",personList);
        }

        [HttpPost]
        public IActionResult FindPersonById(int id)
        {
            PersonData personData = new PersonData();
            Person targetPerson = personData.Read(id);
            List<Person> person = new List<Person>();
            if (targetPerson != null)
            {
                person.Add(targetPerson);
            }
            return PartialView("_PeopleListPartial", person);
        }

        [HttpPost]
        public IActionResult DeletePersonById(int id)
        {
            PersonData personData = new PersonData();
            Person targetPerson = personData.Read(id);
            List<Person> person = new List<Person>();
            bool success = false;
            if (targetPerson != null)
            {
                success = personData.Delete(targetPerson);
            }
            if (success)
            {
                return StatusCode(200);
            }
            return StatusCode(404);
        }






    }


}
