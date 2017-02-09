using Help_Desk_Log_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace Help_Desk_Log_API.Services
{
    public class LogsService: ILogsService
    {
        private readonly Context _context;
        public LogsService(Context context)
        {
            _context = context;
        }

        public void Add(Logs log)
        {
            _context.Logs.Add(log);
            _context.SaveChanges();
        }

        public IEnumerable<LogInfo> GetLogInfo()
        {
            return _context.Set<LogInfo>().FromSql("usp_GetLog").ToList();
        }


    }
}
