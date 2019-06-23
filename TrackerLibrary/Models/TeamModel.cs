using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Jedinstveni identifikator za svaki pojedinacni tim.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Lista clanova tima koja je popunjena objektima koji predstavljaju igrace.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Predstavlja ime tima.
        /// </summary>
        public String TeamName { get; set; }
    }
}
