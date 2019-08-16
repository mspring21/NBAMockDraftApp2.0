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
    }
}
