using APIJago.Model;
using APIJago.Model.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIJago.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly JagoContext _jagoContext;

        public ServiceController(JagoContext JagoContext)
        {
            _jagoContext = JagoContext;

        }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Service> Get()
        {
            return _jagoContext.Services;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Service Get(Guid id)
        {
            return _jagoContext.Services.SingleOrDefault(j => j.Id == id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Service service)
        {
            _jagoContext.Services.Add(service);
            _jagoContext.SaveChanges();
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Service service)
        {
            _jagoContext.Services.Update(service);
            _jagoContext.SaveChanges();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = _jagoContext.Services.FirstOrDefault(j => j.Id == id);
            if (item != null)
            {
                _jagoContext.Services.Remove(item);
                _jagoContext.SaveChanges();
            }
        }
        [HttpGet("GetClientByServiceId{id}")]
        public IEnumerable<Client> GetClient(Guid id)
        {
           yield return _jagoContext.Clients.SingleOrDefault(c => c.Id == id);
        }

        [HttpGet("GetProductByServiceId{id}")]
        public IEnumerable<Product> GetProduct(Guid id)
        {
            yield return _jagoContext.Products.SingleOrDefault(c => c.Id == id);
        }

        [HttpGet("GetServicePlan")]
        public async Task<IEnumerable<EnumType>> GetServicePlan()
        {
            return new List<EnumType>()
            {
                new EnumType("Mensal",Convert.ToString((int)EServicePlan.Monthly)),
                new EnumType("Anual",Convert.ToString((int)EServicePlan.Annual)),
            };
        }
    }
}
