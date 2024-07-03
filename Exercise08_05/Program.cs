using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.num = 'a';
            obj.symb = 'a';
            while (obj)
            {
                Console.WriteLine(obj.symb);
                obj.num++;
                obj.symb++;
                if(obj.num == 'z' + 1)
                {
                    obj.num = -10;
                }
            }
        }
    }
}
