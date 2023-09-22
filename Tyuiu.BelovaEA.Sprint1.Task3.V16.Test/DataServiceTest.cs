using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.BelovaEA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();

            double x1 = 1.2;
            double x2 = 1.0;

            double b = -x1 - x2;
            Assert.AreEqual(-2.2, ds.CoeffOfQuadraticEquation(x1, x2));
        }
    }
}
