using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KropchevSR.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] FunctionArray;
            int len = (stopValue - startValue) + 1;
            FunctionArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 != 0)
                {
                    y = Math.Sin(x) / (x + 1.2) - Math.Sin(x) * 2 - 2 * x;
                    y = Math.Round(y, 2);
                    FunctionArray[count] = y;
                }
                else { FunctionArray[count] = 0; }
                count++;
            }
            return FunctionArray;
        }
    }
}
