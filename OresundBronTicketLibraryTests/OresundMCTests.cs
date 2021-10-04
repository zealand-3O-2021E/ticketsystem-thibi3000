using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundMCTests
    {      

        [TestMethod()]
        public void PriceTestNoBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            OresundMC mc = new("1-ABC-1", datetime);
            

            //Act
            double MCPrice = mc.Price(false);

            //Assert
            Assert.AreEqual(210, MCPrice);
        }

        [TestMethod()]
        public void PriceTestBrobizz()
        {
            //Arrange
            DateTime datetime = new DateTime(2021, 09, 25);
            OresundMC mc = new("1-ABC-1", datetime);


            //Act
            double MCPrice = mc.Price(true);

            //Assert
            Assert.AreEqual(73, MCPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange            
            DateTime datetime = new DateTime(2021, 09, 25);
            OresundMC mc = new("1-ABC-1", datetime);

            //Act
            string type = mc.VehicleType();

            //Assert
            Assert.AreEqual("Oresund MC", type);
        }
    }
}