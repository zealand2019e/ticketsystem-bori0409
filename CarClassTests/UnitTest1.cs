using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLibrary;

namespace CarClassTests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void PriceTesting()
        {
            Car car = new Car();
            double price = car.Price();

            Assert.AreEqual(240, price);

        }
        [TestMethod]
        public void TypeOfTheVehicle()
        {
            Car car = new Car();
            string Type = car.VehicleType();

            Assert.AreEqual("Car", Type);

        }
        [TestMethod]
        public void PlateTesting()
        {
            Car car = new Car();


            Assert.ThrowsException<Exception>(() =>
            {
                string p = "12345678";
                car.Licenseplate = p;
            });

        }
        
    }
}
