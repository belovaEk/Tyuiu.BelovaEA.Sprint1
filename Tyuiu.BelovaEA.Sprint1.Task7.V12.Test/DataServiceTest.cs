using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint1.Task7.V12.Lib;

namespace Tyuiu.BelovaEA.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            Assert.AreEqual(45, ds.Calculate(x, y));
        }
    }
}
