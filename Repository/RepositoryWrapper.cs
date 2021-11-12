using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DatabaseContext _context;

        private readonly IHotelRepository _hotels;
        private readonly ICountryRepository _countries;

        public IHotelRepository Hotels 
        { 
            get => _hotels ?? new HotelRepository(_context);
        }

        public ICountryRepository Countries
        {
            get => _countries ?? new CountryRepository(_context);
        }

        public RepositoryWrapper(DatabaseContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
