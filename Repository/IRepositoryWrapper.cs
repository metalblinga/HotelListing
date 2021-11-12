using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryWrapper
    {

        public IHotelRepository Hotels { get; }
        public ICountryRepository Countries { get; }
        void Save();

    }
}
