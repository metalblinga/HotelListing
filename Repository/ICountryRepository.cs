using Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICountryRepository : IRepositoryBase<Country>
    {
        public IEnumerable<Country> GetAllCountries();

        public Country GetCountryById(int id);
    }
}
