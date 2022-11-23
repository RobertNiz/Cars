using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class carsController : ControllerBase
    {
        private ICarServices _carServices;
        public carsController(ICarServices carsService)
        {
            _carServices = carsService;
        }
        // GET: api/<carsController>
        [HttpGet]
        public List<string> Get()
        {
            return _carServices.GetCars();
        }
        
        // GET api/<carsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<carsController>
        [HttpPost]
        public List<string> Post( string value)
        {
            
            return _carServices.PostCars(value);
        }
        

        // PUT api/<carsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<carsController>/5
        [HttpDelete("{id}")]
        public List<string> Delete(string car)
        {
            return _carServices.DeleteCars(car);
        }
    }
}
