using Entities.Responses.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Services.Hotel
{
    public interface IHotelService
    {

        public IEnumerable<GetHotelResponse> GetAll();

        public GetHotelResponse GetById(int id);

    }
}
