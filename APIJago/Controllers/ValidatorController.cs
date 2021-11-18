using APIJago.Model;
using APIJago.Model.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIJago.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidatorController : ControllerBase
    {
        private readonly JagoContext _jagoContext;

        public ValidatorController(JagoContext JagoContext)
        {
            _jagoContext = JagoContext;

        }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Validator> Get()
        {
            return _jagoContext.Validators;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Validator Get(Guid id)
        {
            return _jagoContext.Validators.SingleOrDefault(j => j.Id == id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Validator validator)
        {
            _jagoContext.Validators.Add(validator);
            _jagoContext.SaveChanges();
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Validator validator)
        {
            _jagoContext.Validators.Update(validator);
            _jagoContext.SaveChanges();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = _jagoContext.Validators.FirstOrDefault(j => j.Id == id);
            if (item != null)
            {
                _jagoContext.Validators.Remove(item);
                _jagoContext.SaveChanges();
            }
        }
        [HttpGet("GetSupplierByValidatorId{id}")]
        public IEnumerable<Fornecedor> GetSupplier(Guid id)
        {
           yield return _jagoContext.Fornecedores.SingleOrDefault(c => c.Id == id);
        }
    }
}
