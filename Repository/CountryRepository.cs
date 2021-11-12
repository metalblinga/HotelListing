using Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(DatabaseContext context) : base(context)
        {
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return GetAll().ToList();
        }

    }
}
