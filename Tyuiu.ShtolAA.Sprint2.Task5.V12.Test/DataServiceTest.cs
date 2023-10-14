using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ShtolAA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g, m, n;
            g = 2008;
            m = 09;
            n = 01;
            string func = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "31.08.2008";
            Assert.AreEqual(wait, func);

        }
    }
}
