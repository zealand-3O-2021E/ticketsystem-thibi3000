using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {
        public string LicensePlate { get; set; }

        public DateTime Date { get; set; }

        /// <summary>
        /// Constructor for the MC class
        /// </summary>
        /// <param name="plate">plate of the MC</param>
        /// <param name="date">date the MC crossed the bridge</param>
        public MC(string plate, DateTime date)
        {
            LicensePlate = plate;
            Date = date;
        }

        /// <summary>
        /// Method that returns the price for a MC
        /// </summary>
        /// <returns>125</returns>
        public double price()
        {
            return 125;
        }

        /// <summary>
        /// Method that returns the vehicletype
        /// </summary>
        /// <returns>MC</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
