using System;

namespace Help_Desk_Log_API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services;

    [Route("api/[controller]/[action]")]
    public class ReasonsController : BaseController
    {
        private readonly IReasonsService _service;

        public ReasonsController(IReasonsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult List()
        {
            try
            {
                _data = _service.GetReasons();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var json = new JsonResponse
            {
                msg = _msg,
                data = _data,
                hasErrors = _hasErrors,
                id = _id
            };

            return Ok(json);
        }


    }
}
