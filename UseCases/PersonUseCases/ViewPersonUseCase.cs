using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewPersonUseCase : IViewPersonUseCase
    {
        private readonly IPersonRepository personRepository;

        public ViewPersonUseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public IEnumerable<Person> Execute()
        {
            return personRepository.GetPersons();
        }
    }
}
