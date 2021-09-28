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
        public void priceTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-12", datetime);

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-12", datetime);

            //Act
            string vehicle = mc.VehicleType();

            //Assert
            Assert.AreEqual("MC", vehicle);
        }
    }
}