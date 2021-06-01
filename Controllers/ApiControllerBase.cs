using Microsoft.AspNetCore.Mvc;

namespace VersioningSwagger_Sample.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ApiControllerBase : ControllerBase
    {
    }
}
