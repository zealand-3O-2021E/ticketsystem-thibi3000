using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// This is the base class for the classes MC and Car
    /// </summary>
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// This is a constructor that takes two parameters
        /// </summary>
        /// <param name="plate">The license plate of the car or MC</param>
        /// <param name="date">The date when the car or MC crossed the bridge</param>
        public Vehicle(string plate, DateTime date)
        {
            LicensePlate = plate;
            Date = date;
        }

        /// <summary>
        /// An abstract method used in the derived classes to return the price
        /// </summary>
        /// <returns>price</returns>
        public abstract double Price();

        /// <summary>
        /// An abstract method used in the derived classes to return the vehicle type
        /// </summary>
        /// <returns>Vehicle type</returns>
        public abstract string VehicleType();
    }
}
