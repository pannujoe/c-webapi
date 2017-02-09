using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Help_Desk_Log_API.Models
{
    public class LogInfo
    {
        public int InfoId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string ContactName { get; set; }
        public string ReasonName { get; set; }
        public string PositionName { get; set; }
        public DateTime LogDate { get; set; }

    }
}
