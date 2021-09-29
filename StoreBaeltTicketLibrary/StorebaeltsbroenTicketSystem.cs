using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltsbroenTicketSystem
    {        
        public ClassLibraryTicketSystem.Car car;
        public double price;

        public StorebaeltsbroenTicketSystem()
        {
            car = new ClassLibraryTicketSystem.Car("1-AB-1", new DateTime(2021, 09, 25));
            price = 0;
        }

        public double CarPrice(bool weekend, bool brobizz)
        {
            if(weekend)
            {
                if (brobizz)
                {
                    return (car.Price(false) * 0.80)*0.95;
                }
                return car.Price(false) * 0.80;
            }
            if (brobizz)
            {
                return car.Price(true);
            }
            return car.Price(false);
        }
    }
}
