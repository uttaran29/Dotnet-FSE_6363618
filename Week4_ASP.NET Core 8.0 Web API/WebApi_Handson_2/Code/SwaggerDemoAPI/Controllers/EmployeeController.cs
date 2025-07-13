using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Uttaran", "Sarkar" };
        }
    }
}
