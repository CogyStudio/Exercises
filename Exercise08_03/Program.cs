using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.x = 1;
            obj1.y = 2;
            MyClass obj2 = new MyClass();
            obj2.x = 3;
            obj2.y = 4;
            Console.WriteLine(obj1 < obj2);
        }
    }
}
