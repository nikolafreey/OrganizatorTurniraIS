using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for person.   
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Predstavlja Ime igraca u timu.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Predstavlja Prezime igraca u timu.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Predstavlja mail adresu igraca u timu.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Predstavlja telefonski broj igraca u timu.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        

    }
}
