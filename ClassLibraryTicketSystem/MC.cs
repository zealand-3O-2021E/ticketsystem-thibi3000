using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class for a MC that inherits from the Vehicle class
    /// </summary>
    public class MC : Vehicle
    {

        /// <summary>
        /// Constructor for the MC class
        /// </summary>
        /// <param name="plate">plate of the MC</param>
        /// <param name="date">date the MC crossed the bridge</param>
        public MC(string plate, DateTime date) : base(plate, date)
        {
            
        }

        /// <summary>
        /// Method that returns the price for a MC
        /// </summary>
        /// <returns>125</returns>
        public override double Price(bool brobizz)
        {
            if (brobizz)
            {
                return 125 * 0.95;
            }
            return 125;
        }

        /// <summary>
        /// Method that returns the vehicletype
        /// </summary>
        /// <returns>MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
