using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        Person GetPersonById(int PersonId);
        void DeletePerson(int PersonId);
    }
}
