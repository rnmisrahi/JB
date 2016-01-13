using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateSpanServer;

namespace TestDateSpan
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateDiffPrecise dateDiff = new DateDiffPrecise();
            DateTime date = DateTime.Now;
            DateTime now = DateTime.Now;

            //Compare exactly 5 years ago
            date = date.AddYears(-5);
            int years = dateDiff.Age(date);
            Assert.IsTrue(years == 5);

            //Test 5 years ago minus 1 day
            date = date.AddDays(1);
            years = dateDiff.Age(date);
            Assert.IsTrue(years == 4);

            //Compare today
            date = DateTime.Now;
            years = dateDiff.Age(date);
            Assert.IsTrue(years == 0);
        }
    }
}
