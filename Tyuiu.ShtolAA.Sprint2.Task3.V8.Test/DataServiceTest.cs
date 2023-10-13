using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint2.Task3.V8.Lib;

namespace Tyuiu.ShtolAA.Sprint2.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
         [TestMethod]
         public void ValidCondition1()
         {
              DataService ds = new DataService();
              double x = 1;
              double res = ds.Calculate(x);
              double wait = -4.588;
              Assert.AreEqual(wait, res);
         }

         [TestMethod]
         public void ValidCondition2()
         {
             DataService ds = new DataService();
             double x = 0;
             double res = ds.Calculate(x);
             double wait = 0.75;
             Assert.AreEqual(wait, res);
         }

         [TestMethod]
         public void ValidCondition3()
         {
             DataService ds = new DataService();
             double x = -10;
             double res = ds.Calculate(x);
             double wait = 0.744;
             Assert.AreEqual(wait, res);
         }

         [TestMethod]
         public void ValidCondition4()
         {
            DataService ds = new DataService();
             double x = -100;
             double res = ds.Calculate(x);
             double wait = -1099.95;
             Assert.AreEqual(wait, res);
         }
    }
}
