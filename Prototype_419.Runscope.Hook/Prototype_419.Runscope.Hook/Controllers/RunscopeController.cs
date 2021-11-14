using Microsoft.AspNetCore.Mvc;

namespace Prototype_419.Runscope.Hook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RunscopeController : ControllerBase
    {
        private readonly ILogger<RunscopeController> _logger;
        public RunscopeController(ILogger<RunscopeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<string> RunscopeInput()
        {
            using (StreamReader reader = new StreamReader(HttpContext.Request.Body))
            {
                var body = await reader.ReadToEndAsync();
                return body;
            }
        }
    }
}
