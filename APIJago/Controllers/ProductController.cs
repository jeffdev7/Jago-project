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
    public class ProductController : ControllerBase
    {
        private readonly JagoContext _jagoContext;

        public ProductController(JagoContext JagoContext)
        {
            _jagoContext = JagoContext;

        }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _jagoContext.Products;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Product Get(Guid id)
        {
            return _jagoContext.Products.SingleOrDefault(j => j.Id == id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _jagoContext.Products.Add(product);
            _jagoContext.SaveChanges();
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Product product)
        {
            _jagoContext.Products.Update(product);
            _jagoContext.SaveChanges();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = _jagoContext.Products.FirstOrDefault(j => j.Id == id);
            if (item != null)
            {
                _jagoContext.Products.Remove(item);
                _jagoContext.SaveChanges();
            }
        }
        [HttpGet("GetClientByProductId{id}")]
        public IEnumerable<Client> GetClient(Guid id)
        {
           yield return _jagoContext.Clients.SingleOrDefault(c => c.Id == id);
        }

        [HttpGet("GetProductType")]
        public async Task<IEnumerable<EnumType>> GetProductType()
        {
            return new List<EnumType>()
            {
                new EnumType("Validador",Convert.ToString((int)EProductType.Validator)),
                new EnumType("Sistema de cadastro",Convert.ToString((int)EProductType.System)),
            };
        }
    }
}
