using Microsoft.AspNetCore.Mvc;

namespace Practical_21.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ContentResult Index()
        {
            return new ContentResult
            {
                Content = "<h1>Hello from published site</h1>",
                ContentType = "text/html"
            };
        }
    }
}