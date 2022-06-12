using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCityUseCase
    {
        IEnumerable<City> Execute();
    }
}