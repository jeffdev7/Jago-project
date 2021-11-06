using APIJago.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIJago.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepresentativeController : ControllerBase
    {
        private readonly JagoContext _jagoContext;

        public RepresentativeController(JagoContext JagoContext)
        {
            _jagoContext = JagoContext;

        }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Representative> Get()
        {
            return _jagoContext.Representatives;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Representative Get(Guid id)
        {
            return _jagoContext.Representatives.SingleOrDefault(j => j.Id == id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Representative representative)
        {
            _jagoContext.Representatives.Add(representative);
            _jagoContext.SaveChanges();
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Representative representative)
        {
            _jagoContext.Representatives.Update(representative);
            _jagoContext.SaveChanges();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = _jagoContext.Representatives.FirstOrDefault(j => j.Id == id);
            if (item != null)
            {
                _jagoContext.Representatives.Remove(item);
                _jagoContext.SaveChanges();
            }
        }
        [HttpGet("GetClientByRepresentativeId{id}")]
        public IEnumerable<Client> GetClient(Guid id)
        {
           yield return _jagoContext.Clients.SingleOrDefault(c => c.Id == id);
        }
    }
}
