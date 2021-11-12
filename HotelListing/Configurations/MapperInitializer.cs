using AutoMapper;
using Entities.Domain;
using Entities.Requests.Country;
using Entities.Requests.Hotel;
using Entities.Responses.Country;
using Entities.Responses.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations
{
    public class MapperInitializer : Profile
    {

        public MapperInitializer()
        {
            CreateMap<Hotel, GetHotelResponse>().ReverseMap();
            CreateMap<Hotel, CreateHotelRequest>().ReverseMap();
            CreateMap<Country, GetCountryResponse>().ReverseMap();
            CreateMap<Country, CreateCountryRequest>().ReverseMap();
        }

    }
}
