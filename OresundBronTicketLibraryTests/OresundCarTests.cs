using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundCarTests
    {       

        [TestMethod()]
        public void PriceTestNoBrobizz()
        {
            //Arrange          
            DateTime datetime = new DateTime(2021, 09, 25);
            OresundCar oresundCar = new("1-ABC-1", datetime);
            
            //Act
            double carPrice = oresundCar.Price(false);

            //Assert
            Assert.AreEqual(410, carPrice);
        }

        [TestMethod()]
        public void PriceTestBrobizz()
        {
            //Arrange          
            DateTime datetime = new DateTime(2021, 09, 25);
            OresundCar oresundCar = new("1-ABC-1", datetime);
            
            //Act
            double carPrice = oresundCar.Price(true);

            //Assert
            Assert.AreEqual(161, carPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            OresundCar oresundCar = new("1-ABC-1", datetime);

            //Act
            string type = oresundCar.VehicleType();

            //Arrange
            Assert.AreEqual("Oresund car", type);
        }
    }
}