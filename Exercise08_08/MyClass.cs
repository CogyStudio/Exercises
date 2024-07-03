using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_08
{
    internal class MyClass
    {
        public int[] ints;
        public override string ToString()
        {
            String result = "[";
            for(int i = 0; i < ints.Length - 1; i++)
            {
                result += ints[i] + ", ";
            }
            result += ints[ints.Length - 1] + "]";
            return result;
        }
        public static implicit operator String(MyClass obj)
        {
            return obj.ToString();
        }
        public static implicit operator int(MyClass obj)
        {
            int result = 0;
            for(int i = 0; i < obj.ints.Length; i++)
            {
                result += obj.ints[i];
            }
            return result;
        }
        public static implicit operator MyClass(int num)
        {
            MyClass result = new MyClass();
            result.ints = new int[num];
            for(int i = 0; i < num; i++)
            {
                result.ints[i] = 0;
            }
            return result;
        }
    }
}
