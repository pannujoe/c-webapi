using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Help_Desk_Log_API.Controllers
{
    using Help_Desk_Log_API.Models;
    using Services;

    [Route("api/[controller]/[action]")]
    public class UsersController : BaseController
    {

        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
           _service = service;
        }

        [HttpGet]
        public JsonResponse List()
        {
            try
            {
                //var data = _service.GetUsers();
                //foreach (var datum in data)
                //{
                //    datum.fullName = $"{datum.fName} {datum.lName}";
                //}
                //_data = data;

                 _data = _service.GetUsers();
            }

            catch (Exception ex)
            {
                _msg = ex.Message;
            }


            var json = new JsonResponse
            {
                msg = _msg,
                data = _data,
                hasErrors = _hasErrors,
                id = _id
            };

            return json;

        }
        

    }
}
