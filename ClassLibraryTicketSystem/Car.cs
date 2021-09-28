using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class for a car that inherits from the Vehicle class
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor for the car class
        /// </summary>
        /// <param name="plate">Plate of the car</param>
        /// <param name="date">Date the car crossed the bridge</param>
        public Car(string plate, DateTime date) : base(plate, date)
        {
            
        }

        /// <summary>
        /// Method that returns a price for the cars crossing the bridge
        /// </summary>
        /// <returns>240</returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// Method that returns the type of vehicle
        /// </summary>
        /// <returns>Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
