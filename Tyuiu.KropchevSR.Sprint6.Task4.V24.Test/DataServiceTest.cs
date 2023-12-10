using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint6.Task4.V24.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] wait = new double[] { 7.83, 6.22, 6.36, 6.96, -0.52, 0, -3.3, -5.53, -6.25, -6.63, -8.24 };
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
