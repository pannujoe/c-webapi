using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Help_Desk_Log_API.Controllers
{
    public class BaseController : Controller
    {
        internal bool _hasErrors = false;
        internal string _msg = string.Empty;
        internal object _data;
        internal int _id = 0;
    }
}
