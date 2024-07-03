using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_06
{
    internal class MyClass
    {
        public int num;
        public static bool operator true(MyClass obj)
        {
            switch (obj.num)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    return true;
                default:
                    return false;
            }
        }
        public static bool operator false(MyClass obj)
        {
            if(obj.num < 1 ||  obj.num > 10)
            {
                return true;
            }
            return false;
        }
        public static MyClass operator &(MyClass obj1, MyClass obj2)
        {
            if (obj1)
            {
                return obj2;
            }
            else
            {
                return obj1;
            }
        }
        public static MyClass operator |(MyClass obj1, MyClass obj2)
        {
            if (obj1)
            {
                return obj1;
            }
            else
            {
                return obj2;
            }
        }

    }
}
