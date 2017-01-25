using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStatsDatabase
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
        public Stat Stat { get; set; }
    }
}
