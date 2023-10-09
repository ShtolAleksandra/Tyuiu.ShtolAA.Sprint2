using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtolAA.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a + 3 > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a + 3 > b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (b > a) ^ (c < d);

            return res;

        }
    }
}
