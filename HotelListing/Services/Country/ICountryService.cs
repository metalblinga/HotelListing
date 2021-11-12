using Entities.Responses.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Services
{
    public interface ICountryService
    {

        public GetCountryResponse GetCountryById(int id);

    }
}
