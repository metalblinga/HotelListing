using HotelListing.Services.Hotel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {

        private readonly IHotelService _hotelService;
        private readonly ILogger<HotelController> _logger;

        public HotelController(IHotelService hotelService, ILogger<HotelController> logger)
        {
            _hotelService = hotelService;
            _logger = logger;
        }

        // GET: api/<HotelController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_hotelService.GetAll());
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {nameof(Get)}");
                return StatusCode(500, "Internal server error.");
            }
            
        }

        // GET api/<HotelController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_hotelService.GetById(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {nameof(Get)}");
                return StatusCode(500, "Internal server error.");
            }
        }

        // POST api/<HotelController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HotelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HotelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
