using Classlist.Services;
using Microsoft.AspNetCore.Mvc;

namespace Classlist.Controllers
{
    [Route("api/clazzes")]
    [ApiController]
    public class ClazzesController : ControllerBase
    {
        private readonly ClazzesService clazzesService;

        public ClazzesController(ClazzesService clazzesService)
        {
            this.clazzesService = clazzesService;
        }

        [HttpGet]
        public IActionResult GetClazzes()
        {
            return Ok(clazzesService.GetClazzes());
        }
    }
}
