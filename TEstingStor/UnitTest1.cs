using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;


namespace TEstingStor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CarStor cars = new CarStor();
           
            DateTime dates = new DateTime(2019,9,22);
            cars.Date = dates;
            double ac = cars.Price();
            
            Assert.AreEqual(ac, 182.4, 0.1);





        }
    }
}
