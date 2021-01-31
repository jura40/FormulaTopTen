using formulaTopTen.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formulaTopTen.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly ApplikationDbContext _dbContext;
        private readonly IMemoryCache _memoryCache;

        public DriverController(ApplikationDbContext dbContext, IMemoryCache memoryCache)
        {
            _dbContext = dbContext;                     // dependecy injection  
            _memoryCache = memoryCache;                 // dependecy injection
        }

        // GET: api/<DriverController>
        [HttpGet("GetAll")]
        public IEnumerable<Driver> GetAll()
        {
            var cacheKey = $"Get_All_Drivers-";                                    // memoryCache

            if (_memoryCache.TryGetValue(cacheKey, out string cachedValue))
                return (IEnumerable<Driver>)Ok(cachedValue);

            try                                                                       // exception
            {
                 var drivers = _dbContext.driver.Include(c => c.coments).ToArray();
                 

                _memoryCache.Set(cacheKey, drivers);

                return drivers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriverController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]

        public void Delete(int id)
        {
        }
    }
}
