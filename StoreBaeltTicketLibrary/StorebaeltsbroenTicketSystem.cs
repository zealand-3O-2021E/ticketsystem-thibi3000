using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltsbroenTicketSystem : ClassLibraryTicketSystem.Car
    {
        private bool _isWeekend;

        public StorebaeltsbroenTicketSystem(string plate, DateTime date) : base(plate, date)
        {
            LicensePlate = plate;
            Date = date;
            _isWeekend = false;
        }

        /// <summary>
        /// Calculates the price for a car ticket with weekend and brobizz discount.
        /// </summary>
        /// <param name="weekend"></param>
        /// <param name="brobizz"></param>
        /// <returns></returns>
        public override double Price(bool brobizz)
        {
            int weekday = (int)Date.DayOfWeek;

            if (weekday == 0 || weekday == 6)
            {
                _isWeekend = true;
                if (brobizz)
                {
                    return (240 * 0.80) * 0.95;
                }
                return 240 * 0.80;
            }
            if (brobizz && _isWeekend == false)
            {
                return 240 * 0.95;
            }
            return 240;
        }
    }
}
