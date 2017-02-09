using Help_Desk_Log_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Help_Desk_Log_API.Services
{
    public class PositionsService : IPositionsService
    {
        private readonly Context _context;

        public PositionsService(Context context)
        {
            _context = context;
        }

        public IEnumerable<dynamic> GetPositions()
        {
            return _context.Positions.ToList();
        }
    }
}
