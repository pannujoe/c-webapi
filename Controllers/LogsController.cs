using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Help_Desk_Log_API.Services;
using Help_Desk_Log_API.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Help_Desk_Log_API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class LogsController : BaseController
    {
        private readonly ILogsService _service;
        public LogsController(ILogsService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Add([FromBody]Logs log)
        {
            try
            {
                var date = DateTime.Now;
                _service.Add(log);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpGet]
        public IActionResult GetLogInfo()
        {
            try
            {
                _data = _service.GetLogInfo();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var json = new JsonResponse
            {
                data = _data,
                msg = _msg,
                id = _id,
                hasErrors = _hasErrors
            };

            return Ok(json);

        }

    }
}
