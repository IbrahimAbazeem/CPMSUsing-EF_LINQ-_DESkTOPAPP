using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPMS.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string Supervisor { get; set; }
        public int ProjectId { get; set; }

        public Project Project { get; set; }
       
       
    }
}
