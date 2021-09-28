using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class for a car
    /// </summary>
    public class Car
    {
        public string Licenseplate { get; set; }

        public DateTime Date { get; set; }

        public Car(string plate, DateTime date)
        {
            Licenseplate = plate;
            Date = date;
        }


        /// <summary>
        /// Method that returns a price for the cars crossing the bridge
        /// </summary>
        /// <returns>240</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// Method that returns the type of vehicle
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
