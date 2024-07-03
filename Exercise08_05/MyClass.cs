using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_05
{
    internal class MyClass
    {
        public int num;
        public char symb;
        public static bool operator true(MyClass obj)
        {
            if(obj.num - obj.symb <= 10 && obj.num - obj.symb >= -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(MyClass obj)
        {
            if (obj.num - obj.symb > 10 && obj.num - obj.symb < -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
