using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Predstavlja jedinstveni identifikator meca.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Predstavlja jedinstveni identifikator tima jer iz baze ne mozemo unjeti podatke u objekat TeamCompeting tipa TeamModel
        /// </summary>
        public int TeamCompetingId { get; set; }
        
        /// <summary>
        /// Predstavlja jedan od timova u mecu.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        
        /// <summary>
        /// Predstavlja rezultat koji je postigao dati tim.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Predstavlja jedinstveni identifikator prethodnog meca jer iz baze ne mozemo unjeti podatke u objekat ParentMatchup tipa MatchupModel
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Predstavlja mec iz koga je ovaj tim izasao kao pobjednik.
        /// Predstavlja prethodnu utakmicu datog tima.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
