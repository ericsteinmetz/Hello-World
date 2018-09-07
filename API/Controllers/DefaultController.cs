using System.Web.Http;

namespace API.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
