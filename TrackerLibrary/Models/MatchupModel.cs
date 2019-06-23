using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Predstavlja jedinstveni identifikator meca.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Predstavlja listu Utakmica koja sadrzi objekat koji predstavlja tim, rezultat
        /// i prethodni mec iz koga je dati tim izasao kao pobjednik.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// ID iz baze koji koristimo da pronadjemo pobjednika jer ne mozemo iz baze povuci informacije i upisati ih u objekat Winner tipa TeamModel
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Predstavlja objekat tima koji je pobjedio.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Predstavlja broj runde koja se igra.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
            {
                get
                {
                    string output = "";

                    foreach(MatchupEntryModel me in Entries)
                    {
                        if (me.TeamCompeting != null)
                        {
                            if (output.Length == 0)
                            {
                                output = me.TeamCompeting.TeamName;
                            }
                            else
                            {
                                output += $" vs. { me.TeamCompeting.TeamName }";
                            } 
                        }
                        else
                        {
                            output = "Mec je jos neodredjen.";
                            break;
                        }
                    }

                return output;
                }

            }

    }
}
