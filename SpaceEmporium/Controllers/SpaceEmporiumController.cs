using Microsoft.AspNetCore.Mvc;

namespace SpaceEmporium.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    [ApiVersion("2")]
    [ApiController]
    public class SpaceEmporiumController : ControllerBase
    {
        [MapToApiVersion("1")]
        [HttpGet("MoonRocks")]
        public IActionResult GetMoonRocks() => Ok("Here are some Moon Rocks! v1");
        
        [MapToApiVersion("2")]
        [HttpGet("MoonRocks")]
        public IActionResult GetMoonRocksV2() => Ok("Here are some Moon Rocks! v2");
    }
}
