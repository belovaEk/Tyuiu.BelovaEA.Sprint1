using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.BelovaEA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAngleToHoursMinutes()
        {
            DataService ds = new DataService();
            double f = 30;
            Assert.AreEqual(1, ds.AngleToHoursMinutes(f));
        }
    }
}
