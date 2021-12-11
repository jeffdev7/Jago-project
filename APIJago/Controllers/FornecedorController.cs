using APIJago.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIJago.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly JagoContext _jagoContext;

        public FornecedorController(JagoContext JagoContext)
        {
            _jagoContext = JagoContext;

        }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Fornecedor> Get()
        {
            return _jagoContext.Fornecedores;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Fornecedor Get(Guid id)
        {
            return _jagoContext.Fornecedores.SingleOrDefault(j => j.Id == id);
        }


        //[HttpPost]
        //public void Post([FromBody] Fornecedor fornecedor)
        //{
        //    _jagoContext.Fornecedores.Add(fornecedor);
        //    _jagoContext.SaveChanges();
        //}

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Fornecedor fornecedor)
        {
            _jagoContext.Fornecedores.Update(fornecedor);
            _jagoContext.SaveChanges();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = _jagoContext.Fornecedores.FirstOrDefault(j => j.Id == id);
            if (item != null)
            {
                _jagoContext.Fornecedores.Remove(item);
                _jagoContext.SaveChanges();
            }
        }
        
    }
}
