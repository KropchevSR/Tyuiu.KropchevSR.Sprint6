using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KropchevSR.Sprint6.Task3.V18.Lib
{
    public class DataService : ISprint6Task3V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            int Rows = 5;
            int Colms = 5;
            for (int i = 0; i < Colms;i++)
            {
                for (int j = 0; j < Rows;j++)
                {
                    if ((i == 3) && (matrix[i, j] % 2 == 0))
                    { matrix[i, j] = 0; }
                }
            }
            return matrix;
        }
    }
}
