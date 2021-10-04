using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary
{
    public class OresundMC : MC
    {
        /// <summary>
        /// This is the class for a motorcycle crossing the oresund bridge
        /// </summary>
        public OresundMC(string plate, DateTime date) : base(plate, date)
        {

        }

        /// <summary>
        /// This method returns the prize of the ticket for a motorcycle
        /// </summary>
        /// <param name="brobizz">this parameter is used to notice if a brobizz is used or not</param>
        /// <returns></returns>
        public override double Price(bool brobizz)
        {
            if (brobizz)
            {
                return 73;
            }
            return 210;
        }

        /// <summary>
        /// This method returns the type of the vehicle crossing the bridge
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }

}
