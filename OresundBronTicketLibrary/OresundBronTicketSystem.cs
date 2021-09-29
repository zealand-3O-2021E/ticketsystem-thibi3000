using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary
{
    public class OresundBronTicketSystem
    {
        public double CarPrice(ClassLibraryTicketSystem.Car car, bool brobizz)
        {
            if (brobizz)
            {
                return 161;
            }
            return 410;
        }

        public double MCPrice(ClassLibraryTicketSystem.MC mc, bool brobizz)
        {
            if (brobizz)
            {
                return 73;
            }
            return 210;
        }

        public string CarType(ClassLibraryTicketSystem.Car car)
        {
            return "Oresund car";
        }

        public string MCType(ClassLibraryTicketSystem.MC mc)
        {
            return "Oresund MC";
        }
    }
}
