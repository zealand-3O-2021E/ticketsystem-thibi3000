using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;


namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebaeltsbroenTicketSystemTests
    {

        [TestMethod()]
        public void CarPriceNoBrobizzNoWeekendTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 23);
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem("1-ABC", datetime);

            //Act
            double price = store.Price(false);

            //Assert
            Assert.AreEqual(240, price);
        }

        [TestMethod()]
        public void CarPriceBrobizzNoWeekendTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 23);
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem("1-ABC", datetime);

            //Act
            double price = store.Price(true);

            //Assert
            Assert.AreEqual(228, price);
        }

        [TestMethod()]
        public void CarPriceNoBrobizzWeekendTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem("1-ABC", datetime);

            //Act
            double price = store.Price(false);

            //Assert
            Assert.AreEqual(192, price);
        }

        [TestMethod()]
        public void CarPriceBrobizzWeekendTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            StorebaeltsbroenTicketSystem store = new StorebaeltsbroenTicketSystem("1-ABC", datetime);

            //Act
            double price = store.Price(true);

            //Assert
            Assert.AreEqual(182.4, price, 0.01);
        }
    }
}