using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Help_Desk_Log_API.Models
{
    public class Logs
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public int PositionId { get; set; }
        public int ReasonId { get; set; }
        public int ContactId { get; set; }

        public DateTime logDate { get; set; }

    }
}

