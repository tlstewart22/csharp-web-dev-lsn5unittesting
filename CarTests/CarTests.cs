using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        //TODO: constructor sets gasTankLevel properly
        Car test_car;
        [TestInitialize]
        public void CreatCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }
        [TestMethod]
        public void TestGasTankLevel()
        {
            // Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        [TestMethod]
        public void TestGasTankExceedingTankRange()
        {
            test_car.Drive(501);
            Assert.AreNotEqual(501, test_car.Odometer, .001);
        }

        [TestCleanup]
        public void CleanupAfterTest()
        {
            Console.WriteLine("Cleaning up the test");
            test_car = null;
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
