using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.num = 5;
            MyClass obj2 = new MyClass();
            obj2.num = 3;
            obj1 *= obj2;
            Console.WriteLine(obj1.num);
        }
    }
}
