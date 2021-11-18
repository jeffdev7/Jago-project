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
    public class PartnerController : ControllerBase
    {
        private readonly JagoContext _jagoContext;

        public PartnerController(JagoContext JagoContext)
        {
            _jagoContext = JagoContext;

        }
        // GET: api/<PartnerController>
        [HttpGet]
        public IEnumerable<Partner> Get()
        {
            return _jagoContext.Partners;
        }

        // GET api/<PartnerController>/5
        [HttpGet("{id}")]
        public Partner Get(Guid id)
        {
            return _jagoContext.Partners.SingleOrDefault(j => j.Id == id);
        }

        // POST api/<PartnerController>
        [HttpPost]
        public void Post([FromBody] Partner partner)
        {
            _jagoContext.Partners.Add(partner);
            _jagoContext.SaveChanges();
        }

        // PUT api/<PartnerController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Partner partner)
        {
            _jagoContext.Partners.Update(partner);
            _jagoContext.SaveChanges();
        }

        // DELETE api/<PartnerController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = _jagoContext.Partners.FirstOrDefault(j => j.Id == id);
            if (item != null)
            {
                _jagoContext.Partners.Remove(item);
                _jagoContext.SaveChanges();
            }
        }
        [HttpGet("GetPartnerByType")]
        public async Task <IEnumerable<EnumType>> GetPartnerByType()
        {
            return new List<EnumType>()
            {
                new EnumType("Jurídico",Convert.ToString((int)EPartnerType.CNPJ)),
                new EnumType("Físico",Convert.ToString((int)EPartnerType.CPF)),
            };
        }
    }
}
