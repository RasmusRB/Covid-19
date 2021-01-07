using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib.Model;

namespace CovidUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly CovidRecord record = new CovidRecord();

        //[TestMethod]
        //public void TestConstructor()
        //{
        //    Assert.IsTrue(record.City.Length < 2);
        //    Assert.IsTrue(record.Household < 1);
        //    Assert.IsTrue(record.Tested < 0);
        //    Assert.IsTrue(record.Sick < 0);
        //}

        [TestMethod]
        public void TestCity()
        {
            record.City = "aa";
            Assert.AreEqual("aa", record.City);
            Assert.ThrowsException<ArgumentException>(() => record.City = "");
            Assert.ThrowsException<ArgumentNullException>(() => record.City = null);
        }

        [TestMethod]
        public void TestHouseHold()
        {
            record.Household = 1;
            Assert.AreEqual(1, record.Household);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Household = 0);
        }

        [TestMethod]
        public void TestTested()
        {
            record.Tested = 1;
            Assert.AreEqual(1, record.Tested);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Tested = -1);
        }

        [TestMethod]
        public void TestSick()
        {
            record.Sick = 1;
            Assert.AreEqual(1, record.Sick);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Sick = -1);
        }
    }
}
