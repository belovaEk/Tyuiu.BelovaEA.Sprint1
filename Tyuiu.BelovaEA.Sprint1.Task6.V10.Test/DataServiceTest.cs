using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.BelovaEA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMiddleLetter()
        {
            DataService ds = new DataService();

            string a = "Программа выдаст вам ответ";

            Assert.AreEqual("Прогамма выдаст вм отет", ds.DeleteMiddleLetter(a));
        }
    }
}
