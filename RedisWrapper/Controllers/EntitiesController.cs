using DataCacheService;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RedisWrapper.Controllers
{
    public class EntitiesController : ApiController
    {
        [HttpGet, Route("get/{setName}/{id}")]
        public dynamic Get(string setName, int id)
        {

            return RedisConnector.Get(setName, id);
        }

        [HttpPost, Route("set/{setName}")]
        public void Post(string setName, [FromBody]dynamic employee)
        {
            if (employee.id == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The item must have an 'id' member."));
            }

            RedisConnector.Set(setName, employee);
        }

        public void Delete(int id)
        {
            RedisConnector.Remove(id);
        }
    }
}
