using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStatsDatabase
{
    public class Team
    {
        public int TeamId { get; set; }
        public string City { get; set; }
        public DateTime Founding { get; set; }
        public int Wins { get; set; }
    }
}
