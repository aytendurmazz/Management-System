using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeletePersonUseCase : IDeletePersonUseCase
    {
        private readonly IPersonRepository personRepository;

        public DeletePersonUseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public void Execute(int PersonId)
        {
            personRepository.DeletePerson(PersonId);
        }
    }
}
