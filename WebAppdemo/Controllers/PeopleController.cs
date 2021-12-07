using Microsoft.AspNetCore.Mvc;
using WebAppdemo.Models;
using WebAppdemo.viewModel;
using System;

namespace WebAppdemo.Controllers
{
    public class PeopleController : Controller
    {


        public IActionResult People()
        {
            PersonData peopleList = new PersonData();
            
            PeopleViewModel peopleListViewModel = new PeopleViewModel()
            { peopleListView = peopleList.Read()};

            if (peopleListViewModel.peopleListView.Count == 0 || peopleListViewModel.peopleListView == null)
            {
                peopleList.PeopleDataBase();
            }

            return View(peopleListViewModel);
        }

        [HttpPost]
        public IActionResult People(PeopleViewModel viewModel)
        {
            PersonData peopleList = new PersonData();
            viewModel.peopleListView.Clear();

            foreach (Person person in peopleList.Read())
            {
                if (person.personName.Contains(viewModel.searchPerson, StringComparison.OrdinalIgnoreCase))
                {
                    viewModel.peopleListView.Add(person);
                }
                else if (person.personCity.Contains (viewModel.searchPerson, StringComparison.OrdinalIgnoreCase))
                {
                    viewModel.peopleListView.Add(person);
                }
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreatePerson(CreatePersonViewModel newPerson)
        {
            PeopleViewModel newViewModel = new PeopleViewModel();
            PersonData addPerson = new PersonData();

            if (ModelState.IsValid)
            {
                newViewModel.personName = newPerson.personName;
                newViewModel.personCity = newPerson.personCity;
                newViewModel.personPhoneNumber = newPerson.personPhoneNumber;
                newViewModel.peopleListView = addPerson.Read();

                addPerson.CreatePerson(newPerson.personName, newPerson.personCity, newPerson.personPhoneNumber);
                ViewBag.Message = "New person added!";

                return View("People", newViewModel);
            }
            ViewBag.Message = "Failed to add new person" + ModelState.Values;
            return View("People", newViewModel);
        }

        public IActionResult DeletePerson(string name)
        {
            PersonData deltePerson = new PersonData();
            Person targetPerson = deltePerson.Read(name);
            deltePerson.Delete(targetPerson);
            return RedirectToAction("People");
        }

    }
}
