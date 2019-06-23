using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// Predstavlja jedinstveni identifikator turnira.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Predstavlja naziv turnira.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Predstavlja cijenu koju placaju svi ucesnici turnira.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Predstavlja listu timova koji su prijavljeni za turnir.Popunjena je objektima koji predstavljaju svaki pojedinacni tim.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Predstavlja listu nagrada koje su odredjene za svako navedeno mjesto.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Predstavlja rundu koja ce da sadrzi svaku utakmicu koja se igrala u datoj kao i sve utakmice odigrane u prethodnoj rundi.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
