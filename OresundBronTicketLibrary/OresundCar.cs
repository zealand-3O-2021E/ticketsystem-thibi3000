using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// This is the class for a car crossing the oresund bridge
    /// </summary>
    public class OresundCar : Car
    {
        public OresundCar(string plate, DateTime date) : base(plate, date)
        {
        }

        /// <summary>
        /// This method returns the prize of the ticket for a car
        /// </summary>
        /// <param name="brobizz">this parameter is used to notice if a brobizz is used or not</param>
        /// <returns></returns>
        public override double Price(bool brobizz)
        {
            if (brobizz)
            {
                return 161;
            }
            return 410;
        }

        /// <summary>
        /// This method returns the type of the vehicle crossing the bridge
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
