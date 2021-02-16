using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockdown
{
    public class Scheduler
    {
        public string profile { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }

        public Scheduler()
        {
            profile = string.Empty;
            dateStart = new DateTime();
            dateEnd = new DateTime();
            timeStart = new DateTime();
            timeEnd = new DateTime();
        }
        
        public Scheduler(string pFile, DateTime dStart, DateTime dEnd, DateTime tStart, DateTime tEnd)
        {
            profile = pFile;
            dateStart = dStart;
            dateEnd = dEnd;
            timeStart = tStart;
            timeEnd = tEnd;
        }
    }
}
