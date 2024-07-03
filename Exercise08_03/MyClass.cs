using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_03
{
    internal class MyClass
    {
        public int x;
        public int y;

        public static bool operator>(MyClass obj1, MyClass obj2)
        {
            if(obj1.x * obj1.x + obj1.y * obj1.y > obj2.x * obj2.x + obj2.y * obj2.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(MyClass obj1, MyClass obj2)
        {
            if (obj1.x * obj1.x + obj1.y * obj1.y < obj2.x * obj2.x + obj2.y * obj2.y)
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
