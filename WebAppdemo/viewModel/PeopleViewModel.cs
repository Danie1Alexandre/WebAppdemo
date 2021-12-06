using System.Collections.Generic;
using WebAppdemo.Models;
using WebAppdemo.viewModel;
namespace WebAppdemo.viewModel
{
    public class PeopleViewModel : CreatePersonViewModel
    {

        public List<Person> peopleListView { get; set; }
        public string searchPerson { get; set; }

        public PeopleViewModel()
        {
            peopleListView = new List<Person>();
        }

    }
}
