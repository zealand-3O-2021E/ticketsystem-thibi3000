using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTestWithoutBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-1", datetime);

            //Act
            double price = mc.Price(false);

            //Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod()]
        public void PriceTestWithBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-1", datetime);

            //Act
            double price = mc.Price(true);

            //Assert
            Assert.AreEqual(118.75, price, 0.01);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-1", datetime);

            //Act
            string vehicle = mc.VehicleType();

            //Assert
            Assert.AreEqual("MC", vehicle);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PlateExceptionTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-12", datetime);

            //Act

            //Assert
            Assert.Fail();
        }
    }
}