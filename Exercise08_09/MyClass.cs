using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_09
{
    internal class MyClass
    {
        public int num;
        public static MyClass operator +(MyClass obj1, MyClass obj2)
        {
            MyClass result = new MyClass();
            result.num = obj1.num + obj2.num;
            return result;
        }
        public static MyClass operator -(MyClass obj1, MyClass obj2)
        {
            MyClass result = new MyClass();
            result.num = obj1.num - obj2.num;
            return result;
        }
        public static MyClass operator *(MyClass obj1, MyClass obj2)
        {
            MyClass result = new MyClass();
            result.num = obj1.num * obj2.num;
            return result;
        }
    }
}
