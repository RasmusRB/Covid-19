using System.Collections.Generic;
using System.Linq;
using CovidService.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib.Model;

namespace ControllerTests
{
    [TestClass]
    public class UnitTest1
    {

        private CovidRecordsController ctx = new CovidRecordsController();

        [TestMethod]
        public void GetTest()
        {
            IEnumerable<CovidRecord> result = ctx.GetAllRecords();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void GetByIdTest()
        {
            CovidRecord result = ctx.GetById(1);
            Assert.AreEqual(1, result.Id);

            result = ctx.GetById(1000);
            Assert.IsNull(result);
        }

        //[TestMethod]
        //public void GetByCityTest()
        //{
        //    IEnumerable<CovidRecord> result = ctx.GetRecordsByCity("Taastrup");
        //    Assert.AreEqual("Taastrup", result);
        //}

        [TestMethod]
        public void PostTest()
        {
            CovidRecord r = new CovidRecord{Id = 23, City = "Holte", Household = 5, Sick = 0, Tested = 5};
            ctx.AddRecord(r);
            IEnumerable<CovidRecord> result = ctx.GetAllRecords();
            Assert.AreEqual(6, result.Count());
        }

        // eksempel delete test
        //[TestMethod]
        //public void DeleteTest()
        //{
        //    int howMany = ctx.Delete(14955); // int id
        //    Assert.AreEqual(0, howMany);

        //    howMany = ctx.Delete(1);
        //    Assert.AreEqual(1, howMany);
        //}


    }
}
