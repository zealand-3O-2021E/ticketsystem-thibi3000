using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundBronTicketSystemTests
    {
        [TestMethod()]
        public void CarPriceTestNoBrobizz()
        {
            //Arrange          
            DateTime datetime = new DateTime(2021, 09, 25);
            Car car = new("1-ABC-1", datetime);
            OresundBronTicketSystem oresund = new OresundBronTicketSystem();

            //Act
            double carPrice = oresund.CarPrice(car, false);

            //Assert
            Assert.AreEqual(410, carPrice);
        }

        [TestMethod()]
        public void CarPriceTestBrobizz()
        {
            //Arrange           
            DateTime datetime = new DateTime(2021, 09, 25);
            Car car = new("1-ABC-1", datetime);
            OresundBronTicketSystem oresund = new OresundBronTicketSystem();

            //Act
            double carPrice = oresund.CarPrice(car, true);

            //Assert
            Assert.AreEqual(161, carPrice);
        }

        [TestMethod()]
        public void MCPriceTestNoBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-1", datetime);
            OresundBronTicketSystem oresund = new OresundBronTicketSystem();

            //Act
            double MCPrice = oresund.MCPrice(mc, false);

            //Assert
            Assert.AreEqual(210, MCPrice);
        }

        [TestMethod()]
        public void MCPriceTestBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-1", datetime);
            OresundBronTicketSystem oresund = new OresundBronTicketSystem();

            //Act
            double MCPrice = oresund.MCPrice(mc, true);

            //Assert
            Assert.AreEqual(73, MCPrice);
        }

        [TestMethod()]
        public void CarTypeTest()
        {
            //Arrange            
            DateTime datetime = new DateTime(2021, 09, 25);
            Car car = new("1-ABC-1", datetime);
            OresundBronTicketSystem oresund = new OresundBronTicketSystem();

            //Act
            string type = oresund.CarType(car);

            //Assert
            Assert.AreEqual("Oresund car", type);
        }

        [TestMethod()]
        public void MCTypeTest()
        {
            //Arrange            
            DateTime datetime = new DateTime(2021, 09, 25);
            MC mc = new("1-ABC-1", datetime);
            OresundBronTicketSystem oresund = new OresundBronTicketSystem();

            //Act
            string type = oresund.MCType(mc);

            //Assert
            Assert.AreEqual("Oresund MC", type);
        }
    }
}