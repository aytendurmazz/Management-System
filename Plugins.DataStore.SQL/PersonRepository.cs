using CoreBusiness;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class PersonRepository : IPersonRepository
    {
        private readonly MarketContext db;

        public PersonRepository(MarketContext db)
        {
            this.db = db;
        }

        public void AddPerson(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
        }

        public void DeletePerson(int PersonId)
        {
            var person = db.People.Find(PersonId);
            if (person == null) return;

            db.People.Remove(person);
            db.SaveChanges();
        }

        public Person GetPersonById(int PersonId)
        {
            return db.People.Find(PersonId);
        }

        public IEnumerable<Person> GetPersons()
        {
            return db.People.ToList();
        }


        public void UpdatePerson(Person person)
        {
            var prod = db.People.Find(person.PersonId);
            prod.FirstName = person.FirstName;
            prod.LastName = person.LastName;
            prod.DateofBirth = person.DateofBirth;
            prod.Gender = person.Gender;
            prod.city = person.city;
            prod.Age = person.Age;
            db.SaveChanges();
        }
    }
}
