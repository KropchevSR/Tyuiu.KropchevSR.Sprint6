using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint6.Task5.V9.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\Степан\source\repos\Tyuiu.KropchevSR.Sprint6\Tyuiu.KropchevSR.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";
            DataService ds = new DataService();
            double[] res = new double[] {0, 0};
            Assert.AreEqual(ds.LoadFromDataFile(path),res);

        }
    }
}
