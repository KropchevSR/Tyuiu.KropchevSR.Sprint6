using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint6.Task2.V4.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] valueWaitArray = new double[stopValue - startValue + 1];

            valueWaitArray[0] = -15.6;
            valueWaitArray[1] = -12.35;
            valueWaitArray[2] = -10.72;
            valueWaitArray[3] = -8.88;
            valueWaitArray[4] = -2.16;
            valueWaitArray[5] = 3.25;
            valueWaitArray[6] = 6.64;
            valueWaitArray[7] = 10.3;
            valueWaitArray[8] = 16.17;
            valueWaitArray[9] = 28.1;
            valueWaitArray[10] = 38.41;

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
