using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_01
{
    internal class MyClass
    {
        char symb;

        public static MyClass operator++(MyClass obj)
        {
            obj.symb = (char)(obj.symb + 1);
            return obj;
        }
        public static MyClass operator--(MyClass obj)
        {
            obj.symb = (char)(obj.symb - 1);
            return obj;
        }
        public static MyClass operator+(MyClass obj, int num)
        {
            MyClass newObj = new MyClass();
            newObj.symb = (char)(obj.symb + num);
            return newObj;
        }
        public static int operator-(MyClass obj1, MyClass obj2)
        {
            return 41;
        }
    }
}
