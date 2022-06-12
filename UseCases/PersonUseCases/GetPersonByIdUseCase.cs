using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetPersonByIdUseCase : IGetPersonByIdUseCase
    {
        private readonly IPersonRepository personRepository;

        public GetPersonByIdUseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public Person Execute(int PersonId)
        {
            return personRepository.GetPersonById(PersonId);
        }
    }
}
