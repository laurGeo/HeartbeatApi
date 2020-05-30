using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HeartbeatApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HeartbeatController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            await Task.Delay(new Random().Next(5000));

            return new JsonResult(new
            {
                HostName = Environment.MachineName,
                HostTimeStamp = DateTime.UtcNow
            });
        }
    }
}
