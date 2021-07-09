using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Sys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeleniumCostpoint.TestRuns;

namespace GATE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public string GetSampleRun()
        {
            Logger log = new Logger();
            var sample = new OpenCloseAllApps_Accounting(log, "C71QCM16");
            sample.Run();
            return "running!!!";
        }
    }
}
