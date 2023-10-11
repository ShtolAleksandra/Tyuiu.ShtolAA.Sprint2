using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtolAA.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((y == 3 && ((x > 2 && x < 6) || (x > 8 && x < 13))) || (y == 4 && ((x > 2 && x < 6) || (x > 8 && x < 13))) || (y == 5 && x > 1 && x < 13) || (y == 6 && x > 1 && x < 14) || (y == 7 && x > 2 && x < 14) || (y == 8 && x > 5 && x < 14) || (((y == 9) || (y == 10)) && ((x > 4 && x < 7) || (x > 10 && x < 13))) || (y == 11 && (x == 6 || x == 11 || x==12)) || (y==12 && (x==4 || x==5 || x==6 || x==12 || x==13)) || (y==13 && (x==2 || x==3)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
