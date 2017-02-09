using System;
using Microsoft.AspNetCore.Mvc;

namespace Help_Desk_Log_API.Controllers
{
    using Models;
    using Services;

    [Route("api/[controller]/[action]")]
    public class PositionsController : BaseController
    {
        private readonly IPositionsService _service;

        public PositionsController(IPositionsService service)
        {
            _service = service;
        }

        [HttpGet]
        public JsonResponse List()
        {
            try
            {
                _data = _service.GetPositions();
            }

            catch (Exception ex)
            {
                _msg = ex.Message;
            }


            var json = new JsonResponse
            {
                msg = _msg,
                data = _data,
                id = _id
            };

            return json;
        }


    }
}

