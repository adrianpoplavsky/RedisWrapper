using DataCacheService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RedisWrapper.Controllers
{
    public class EntitiesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {

           return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public Employee Get(string setName, int id)
        {
            return Program.Get(setName, id);
        }

        // POST api/values
        public void Post(string setName, [FromBody]Employee employee)
        {
            Program.Set(setName, employee);
        }

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/values/5
        public void Delete(int id)
        {
            Program.Remove(id);
        }
    }
}
