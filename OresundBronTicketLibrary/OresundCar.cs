using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary
{
    public class OresundCar : Car
    {
        public OresundCar(string plate, DateTime date) : base(plate, date)
        {
        }

        public override double Price(bool brobizz)
        {
            if (brobizz)
            {
                return 161;
            }
            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
