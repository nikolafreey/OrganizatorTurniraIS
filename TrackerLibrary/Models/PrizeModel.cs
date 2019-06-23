using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Predstavlja mjesto koje je tim zauzeo.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The unique identifier for prize.   
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Predstavlja naziv mjesta koje je tim zauzeo.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Predstavlja iznos nagrade koju je tim osvojio.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Predstavlja procenat od ukupne nagrade koju je tim osvojio.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
