using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class AddPersonUseCase : IAddPersonUseCase
    {
        private readonly IPersonRepository personRepository;

        public AddPersonUseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public void Execute(Person person)
        {
            personRepository.AddPerson(person);
        }
    }
}
