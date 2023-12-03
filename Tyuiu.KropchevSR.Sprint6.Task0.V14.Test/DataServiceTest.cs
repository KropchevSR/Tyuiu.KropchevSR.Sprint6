using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint6.Task0.V14.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double wait = -0.444;
            double res = ds.Calculate(3);
            Assert.AreEqual(wait, res);
        }
    }
}
