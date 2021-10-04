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

        public OresundMC(string plate, DateTime date) : base(plate, date)
        {

        }

        public override double Price(bool brobizz)
        {
            if (brobizz)
            {
                return 73;
            }
            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }

}
