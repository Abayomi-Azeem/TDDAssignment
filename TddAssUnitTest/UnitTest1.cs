using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDAssignment;

namespace TddAssUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("1", "5", "true", "700")]
        [DataRow("2", "17", "true", "2142")]
        [DataRow("1", "3", "false", "600")]
        [DataRow("2", "5", "false", "900")]
        public void TestcToll(string vehicleType, string noOfTrips, string nurtw, string expected)
        {
            var vType = Int16.Parse(vehicleType);
            var vNoOfTrips = Int16.Parse(noOfTrips);
            var isMember = bool.Parse(nurtw);
            var expectedRes = double.Parse(expected);
            var owoda = new Owoda();
            var toll = owoda.TollCalc(vType, isMember, vNoOfTrips);
            Assert.AreEqual(expectedRes, toll);
        }
    }
}
