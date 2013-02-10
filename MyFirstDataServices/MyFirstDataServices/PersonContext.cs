using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstDataServices
{
    public class PersonContext
    {
        private static List<Person> _personList;

        public IQueryable<Person> Persons { get { return _personList.AsQueryable(); } }


        public PersonContext()
        {
            _personList = GetPersonsData();
        }

        public List<Person> GetPersonsData()
        {

            List<Person> persons = new List<Person>();
            persons.Add(new Person()
            {
                ID = 1,
                Name = "Gregg",
                Age = 31,
                Title = "Software Engineer"

            });

            persons.Add(new Person()
            {
                ID = 2,
                Name = "George",
                Age = 38,
                Title = "Software Engineer"

            });

            persons.Add(new Person()
            {
                ID = 3,
                Name = "Rachel",
                Age = 21,
                Title = "Waitress"

            });

            return persons;

        }

    }
}