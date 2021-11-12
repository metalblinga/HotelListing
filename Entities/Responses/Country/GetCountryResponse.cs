using Entities.Responses.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Responses.Country
{
    public class GetCountryResponse
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<GetHotelResponse> Hotels { get; set; }

    }
}
