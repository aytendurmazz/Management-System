using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewCityUseCase : IViewCityUseCase
    {
        private readonly ICityRepository cityRepository;

        public ViewCityUseCase(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public IEnumerable<City> Execute()
        {
            return cityRepository.GetCities();
        }
    }
}
