using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAAPP.Models
{
    public class DraftVM
    {
        public IList<Team> Teams { get; set; }
        public IList<Prospect> Prospects { get; set; }
        public Team TeamOnTheBoard { get; set; }
        public IList<Prospect> AvailableProspects { get; set; }
        public IList<Prospect> DraftedProspects { get; set; }
        public IList<Prospect> TopFiveProspectsAvailable { get; set; }
        public Prospect Prospect { get; set; }
    }
}
