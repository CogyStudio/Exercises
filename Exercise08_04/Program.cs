using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.text = "Hello";
            obj1.num = 1;
            MyClass obj2 = new MyClass();
            obj2.text = "Hello";
            obj2.num = 1;
            Console.WriteLine(obj1 == obj2);
        }
    }
}
