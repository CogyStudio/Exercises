using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_10
{
    internal class MyClass
    {
        public char symb;
        public static String operator +(MyClass obj1, MyClass obj2)
        {
            String result = obj1.symb.ToString() + obj2.symb.ToString();
            return result;
        }
        public static int operator -(MyClass obj1, MyClass obj2)
        {
            if (obj1.symb > obj2.symb)
            {
                int result = obj1.symb - obj2.symb;
                return result;
            }
            else
            {
                int result = obj2.symb - obj1.symb;
                return result;
            }
        }
        public static implicit operator MyClass(String str)
        {
            MyClass result = new MyClass();
            result.symb = str[0];
            return result;
        }
        public static implicit operator MyClass(int num)
        {
            MyClass result = new MyClass();
            result.symb = (char)num;
            return result;
        }
    }
}
