using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCities();
    }
}
