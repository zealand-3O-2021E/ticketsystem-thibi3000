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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTestWithoutBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            Car car = new("1-ABC-1", datetime);

            //Act
            double price = car.Price(false);

            //Assert
            Assert.AreEqual(240, price);
        }

        [TestMethod()]
        public void PriceTestWithBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            Car car = new("1-ABC-1", datetime);

            //Act
            double price = car.Price(true);
            //Assert
            Assert.AreEqual(228, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            Car car = new("1-ABC-1", datetime);

            //Act
            string type = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", type);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PlateExceptionTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            Car car = new("1-ABC-12", datetime);

            //Act

            //Assert
            Assert.Fail();
        }
    }
}