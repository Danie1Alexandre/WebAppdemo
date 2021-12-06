using System.Collections.Generic;

namespace WebAppdemo.Models
{
    public class Person
    {
        private readonly int personId;
        public int Id 
        {
            get { return personId; }
        }
        public string personName { get; set; }

        public string personCity { get; set; }

        public string personPhoneNumber { get; set; }

        public Person(int id, string name,string city, string phoneNumber)
        {
            this.personId = id;
            personName = name;
            personCity = city;
            personPhoneNumber = phoneNumber;
        }
    }
}
