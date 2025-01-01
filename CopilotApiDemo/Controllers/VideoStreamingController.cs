
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace CopilotApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoStreamingController : ControllerBase
    {
        [HttpGet("{videoName}")]
        public IActionResult GetVideo(string videoName)
        {
            var filePath = Path.Combine("Videos", videoName);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return File(stream, "video/mp4");
        }
    }
}