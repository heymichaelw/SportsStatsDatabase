using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStatsDatabase
{
    public class Stat
    {
        public int StatId { get; set; }
        public int RushAttempts { get; set; }
        public int RushYards { get; set; }
        public int RushTouchdowns { get; set; }
        public int Receptions { get; set; }
        public int ReceivingYards { get; set; }
        public int ReceivingTouchdowns { get; set; }
    }
}
