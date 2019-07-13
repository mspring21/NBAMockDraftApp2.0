using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockDraftAppMVC.Models
{
    public class Prospect
    {
        public string ProspectName { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public int Rating { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public decimal Points { get; set; }
        public decimal Assists { get; set; }
        public decimal Rebounds { get; set; }
        public decimal Blocks { get; set; }
        public decimal Steals { get; set; }
    }
}
