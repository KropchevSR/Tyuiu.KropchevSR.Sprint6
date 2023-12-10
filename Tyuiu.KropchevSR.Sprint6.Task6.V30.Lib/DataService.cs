using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KropchevSR.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string output;
        public string CollectTextFromFile(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                string Line;
                while ((Line = reader.ReadLine()) != null)
                {
                    
                    string[] str = Line.Split(' ');
                    output +=str[3];
                }
                string str1 = output;
                output = "";
                return str1;
            }
        }
    }
}
