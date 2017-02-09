using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Help_Desk_Log_API.Services
{
    public interface IPositionsService
    {
        IEnumerable<dynamic> GetPositions();
        
    }
}