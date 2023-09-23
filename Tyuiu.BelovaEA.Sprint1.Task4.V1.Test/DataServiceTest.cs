using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.BelovaEA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            double x = 2.0;

            Assert.AreEqual(0.0625, ds.Calculate(x));
        }
    }
}
