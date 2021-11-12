using AutoMapper;
using Entities.Domain;
using Entities.Responses.Country;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Services
{
    public class CountryService : ICountryService
    {

        private readonly IRepositoryWrapper _repository;

        private readonly IMapper _mapper;

        public CountryService(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public GetCountryResponse GetCountryById(int id)
        {

            Country country = _repository.Countries.GetCountryById(id);

            return _mapper.Map<GetCountryResponse>(country);
        }
    }
}
