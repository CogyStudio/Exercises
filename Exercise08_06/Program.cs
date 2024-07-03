using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.num = 2;
            MyClass obj2 = new MyClass();
            obj2.num = 1;
            if (obj1 && obj2)
            {
                Console.WriteLine('A');
            }
            else
            {
                Console.WriteLine('B');
            }
        }
    }
}
