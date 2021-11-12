using Entities.Requests.Hotel;
using Entities.Responses.Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Requests.Country
{
    public class CreateCountryRequest
    {

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country name is too long")]
        public string ShortName { get; set; }

        [Required]
        public ICollection<CreateHotelRequest> Hotels { get; set; }

    }
}
