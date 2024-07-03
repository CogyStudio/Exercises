using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(5);
            Console.WriteLine(~obj1);
            obj1++;
            Console.WriteLine(~obj1);
            obj1--;
            Console.WriteLine(~obj1);
            MyClass obj2 = new MyClass(3);
            Console.WriteLine(~obj2);
            Console.WriteLine(~(obj1 + obj2));
            Console.WriteLine(~(obj1 + 5));
            Console.WriteLine(~(1 + obj1));
        }
    }
}
