using Entities.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public Country GetCountryById(int id)
        {
            return Get(c => c.Id == id)
                .Include(c => c.Hotels)
                .FirstOrDefault();
        }

    }
}
