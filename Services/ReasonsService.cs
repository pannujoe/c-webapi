using Help_Desk_Log_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Help_Desk_Log_API.Services
{
    public class ReasonsService : IReasonsService
    {
        private readonly Context _context;

        public ReasonsService(Context context)
        {
            _context = context;
        }

        public IEnumerable<dynamic> GetReasons()
        {
            return _context.Reasons.ToList();
        }
    }
}
