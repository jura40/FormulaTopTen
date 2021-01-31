using formulaTopTen.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formulaTopTen.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class ComentController : ControllerBase
    {
        private readonly ApplikationDbContext _dbContext;

        public ComentController(ApplikationDbContext dbContext)
        {
            _dbContext = dbContext;                        // dependecy injection
        }

        // GET: api/<ComentController>
        [HttpGet("{id}")]
        public IEnumerable<Coment> Get(int id)
        {
                var coments = _dbContext.coment.Where(x => x.driverId == id).ToArray();
                return coments;
        }

        // GET api/<ComentController>/5
        //[HttpGet("{id}")]
        //public Coment Get(int id)
        //{
        //    using (var context = new ApplikationDbContext())
        //    {
        //        var coment = context.coment.Find(id);

        //        return coment;
        //    }
        //}

        // POST api/<ComentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
