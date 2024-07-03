using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            int[] nums = { 1, 2, 3 };
            obj.ints = nums;
            Console.WriteLine(obj.ToString());
            Console.WriteLine((int)obj);
            Console.WriteLine(((MyClass)10).ToString());
        }
    }
}
