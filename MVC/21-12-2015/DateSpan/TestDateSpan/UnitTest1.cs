using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateSpanServer;

namespace TestDateSpan
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FiveOrSixYears()
        {
            DateDiffImprecise dateDiff = new DateSpanServer.DateDiffImprecise();
            DateTime date = new DateTime();
            date = DateTime.Parse("2010-11-8");
            int n = dateDiff.Age(date);
            Assert.IsFalse(n < 5);
            Assert.IsFalse(n > 6);
        }

        [TestMethod]
        public void EighteenOrNineteenYears()
        {
            DateDiffImprecise dateDiff = new DateDiffImprecise();
            DateTime date = new DateTime();
            date = DateTime.Parse("1997-11-8");
            int n = dateDiff.Age(date);
            Assert.IsFalse(n < 18);
            Assert.IsFalse(n > 19);
        }

        [TestMethod]
        public void DateDiff()
        {
            DateDiffImprecise dateDiff = new DateDiffImprecise();
            DateTime dateA = DateTime.Parse("2003-08-12");
            DateTime dateB = DateTime.Parse("2014-12-31");
            int n = dateDiff.YearDiff(dateA, dateB);
            Assert.AreEqual(n, 11);
            n = dateDiff.YearDiff(dateB, dateA);
            Assert.AreEqual(n, -11);

            dateA = DateTime.Parse("1953-01-03");
            dateB = DateTime.Parse("2015-01-02");
            n = dateDiff.YearDiff(dateA, dateB);
            Assert.AreEqual(n, 62);

            dateA = DateTime.Parse("2015-01-01");
            dateB = DateTime.Parse("2015-01-01");
            n = dateDiff.YearDiff(dateA, dateB);
            Assert.AreEqual(n, 0);

        }

    }
}
