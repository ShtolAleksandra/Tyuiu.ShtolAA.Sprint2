using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint2.Task6.V1.Lib;

namespace Tyuiu.ShtolAA.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();

            Assert.AreEqual(ds.FindMonthDaysCount(1), 31);
            Assert.AreEqual(ds.FindMonthDaysCount(2), 28);
            Assert.AreEqual(ds.FindMonthDaysCount(3), 31);
            Assert.AreEqual(ds.FindMonthDaysCount(4), 30);
            Assert.AreEqual(ds.FindMonthDaysCount(5), 31);
            Assert.AreEqual(ds.FindMonthDaysCount(6), 30);
            Assert.AreEqual(ds.FindMonthDaysCount(7), 31);
            Assert.AreEqual(ds.FindMonthDaysCount(8), 31);
            Assert.AreEqual(ds.FindMonthDaysCount(9), 30);
            Assert.AreEqual(ds.FindMonthDaysCount(10), 31);
            Assert.AreEqual(ds.FindMonthDaysCount(11), 30);
            Assert.AreEqual(ds.FindMonthDaysCount(12), 31);

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(13);
            });
        }
    }
}
