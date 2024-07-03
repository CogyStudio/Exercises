using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.symb = 'a';
            MyClass obj2 = new MyClass();
            obj2.symb = 'd';
            obj1 -= obj2;
            Console.WriteLine(obj1 - obj2);
            Console.WriteLine(obj1.symb);
        }
    }
}
