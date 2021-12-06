using System.Collections.Generic;
namespace WebAppdemo.Models
{
    public class PersonData
    {
        private static List<Person> listofPeople = new List<Person>();
        public static int idCounter;
        public void PeopleDataBase()
        {
            PersonData  personData = new PersonData();
            personData.CreatePerson("Neo", "NewYork", "05199999");
            personData.CreatePerson("Mr.Smith", "LosAngeles", "08197777");
            personData.CreatePerson("Morpheus", "Washington", "07198888");
            personData.CreatePerson("Trinity", "Miami", "071234986");
            personData.CreatePerson("Dozer", "Miami", "07143888");
            personData.CreatePerson("Lady in Red", "San Francisco", "071948898");
        }

        public Person CreatePerson(string name, string city, string phoneNumber)
        {
            Person newPerson = new Person(idCounter, name, city, phoneNumber);
            listofPeople.Add(newPerson);
            idCounter++;
            return newPerson;
        }

        public bool Delete (Person person)
        {
            bool delete = listofPeople.Remove(person);
            return delete;
        }

        public List<Person> Read()
        {
            return listofPeople;
        }

        public Person Read(string name)
        {
            Person  findPerson = listofPeople.Find(person => person.personName ==name);
            return findPerson;
        }

    }
}
