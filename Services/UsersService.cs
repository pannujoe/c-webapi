using Help_Desk_Log_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Help_Desk_Log_API.Services
{
    public class UsersService : IUsersService
    {
        private readonly Context _context;

        public UsersService(Context context)
        {
            _context = context;
        }

        public IEnumerable<dynamic> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
