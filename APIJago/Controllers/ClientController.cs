using APIJago.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIJago.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly JagoContext _jagoContext;

        public ClientController(JagoContext JagoContext)
        {
            _jagoContext = JagoContext;

        }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _jagoContext.Clients;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(Guid id)
        {
            return _jagoContext.Clients.SingleOrDefault(j=>j.Id == id);
        }

      
        //[HttpPost]
        //public void Post([FromBody] Client client)
        //{
        //    _jagoContext.Clients.Add(client);
        //    _jagoContext.SaveChanges();
        //}

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Client client)
        {
            _jagoContext.Clients.Update(client);
            _jagoContext.SaveChanges();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = _jagoContext.Clients.FirstOrDefault(j => j.Id == id);
            if(item != null)
            {
                _jagoContext.Clients.Remove(item);
                _jagoContext.SaveChanges();
            }
        }
        [HttpGet("GetRepresentativeById{id}")]
        public IEnumerable<Representative> GetRepresentative(Guid id)
        {
            yield return _jagoContext.Representatives.SingleOrDefault(c => c.Id == id);
        }
    }
}
