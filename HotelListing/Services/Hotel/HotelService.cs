using AutoMapper;
using Entities.Responses.Hotel;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Domain;
using System.Threading.Tasks;

namespace HotelListing.Services.Hotel
{
    public class HotelService : IHotelService
    {

        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public HotelService(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<GetHotelResponse> GetAll()
        {

            IList<Entities.Domain.Hotel> hotels = _repository.Hotels.GetAll().Include(h => h.Country).ToList();

            return _mapper.Map<IList<GetHotelResponse>>(hotels);
        }

        public GetHotelResponse GetById(int id)
        {
            Entities.Domain.Hotel hotel = _repository.Hotels.Get(h => h.Id == id).Include(h => h.Country).FirstOrDefault();

            return _mapper.Map<GetHotelResponse>(hotel);
        }
    }
}
