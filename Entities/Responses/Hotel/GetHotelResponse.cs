using Entities.Responses.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Responses.Hotel
{
    public class GetHotelResponse
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public GetCountryResponse Country { get; set; }

    }
}
