using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint2.Task4.V25.Lib;

namespace Tyuiu.ShtolAA.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double res = ds.Calculate(x,y);
            double wait = 1.486;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = -400;
            double res = ds.Calculate(x,y);
            double wait = -400;
            Assert.AreEqual(wait, res);
        }
    }
}
