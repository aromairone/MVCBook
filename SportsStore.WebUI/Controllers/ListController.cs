using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Controllers
{
    public class ListController : ApiController
    {
        
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            IProductRepository repository = new EFProductRepository();
          
            IEnumerable<Product> prodNames = repository.Products;
            //IEnumerable<string> prodNames = repository.Products.Select(p => p.Name).ToList();
            return prodNames;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}