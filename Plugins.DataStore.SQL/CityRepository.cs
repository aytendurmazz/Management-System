using CoreBusiness;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CityRepository : ICityRepository
    {
        private readonly MarketContext db;

        public CityRepository(MarketContext db)
        {
            this.db = db;
        }

        public IEnumerable<City> GetCities()
        {
            return db.Cities.ToList();
        }
    }
}
