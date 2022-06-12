using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class EditPersonUseCase : IEditPersonUseCase
    {
        private readonly IPersonRepository personRepository;

        public EditPersonUseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public void Execute(Person person)
        {
            personRepository.UpdatePerson(person);
        }
    }
}
