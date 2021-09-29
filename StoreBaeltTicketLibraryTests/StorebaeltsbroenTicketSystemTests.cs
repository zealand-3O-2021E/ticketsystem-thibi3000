using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebaeltsbroenTicketSystemTests
    {      

        [TestMethod()]
        public void CarPriceNoBrobizzNoWeekendTest()
        {
            //Arrange
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem();

            //Act
            double price = store.CarPrice(false, false);

            //Assert
            Assert.AreEqual(240, price);
        }

        [TestMethod()]
        public void CarPriceBrobizzNoWeekendTest()
        {
            //Arrange
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem();

            //Act
            double price = store.CarPrice(false, true);

            //Assert
            Assert.AreEqual(228, price);
        }

        [TestMethod()]
        public void CarPriceNoBrobizzWeekendTest()
        {
            //Arrange
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem();

            //Act
            double price = store.CarPrice(true, false);

            //Assert
            Assert.AreEqual(192, price);
        }

        [TestMethod()]
        public void CarPriceBrobizzWeekendTest()
        {
            //Arrange
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem();

            //Act
            double price = store.CarPrice(true, true);

            //Assert
            Assert.AreEqual(182.4, price, 0.01);
        }
    }
}