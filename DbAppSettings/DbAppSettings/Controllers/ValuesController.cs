using System.Web.Http;
using DbAppSettings.Models.Values;

namespace DbAppSettings.Controllers
{
    public class ValuesController : ApiController
    {
        // /api/values
        public string[] Get()
        {
            return new[] { "1", "2", "3" };
        }

        // /api/values/id
        public string Get(int id)
        {
            return $"value number {id}";
        }

        // api/values
        public IHttpActionResult Post([FromBody] Thing thing)
        {
            thing.Id = 132;
            return Created("/values", thing);
        }

        // api/values
        public IHttpActionResult Put([FromBody] Thing thing)
        {
            return Ok(thing);
        }

        // api/values/id
        public void Delete(string id)
        {
            // delete resource matching the id
        }
    }
}