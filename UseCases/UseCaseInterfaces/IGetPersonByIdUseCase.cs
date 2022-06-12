using CoreBusiness;

namespace UseCases
{
    public interface IGetPersonByIdUseCase
    {
        Person Execute(int PersonId);
    }
}