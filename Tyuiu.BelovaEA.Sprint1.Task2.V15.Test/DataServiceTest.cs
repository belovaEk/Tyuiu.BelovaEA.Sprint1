using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint1.Task2.V15.Lib;

namespace Tyuiu.BelovaEA.Sprint1.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int x = 2;

            Assert.AreEqual(8, ds.CalculateCubeVolume(x));
        }
    }
}