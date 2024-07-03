using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_02
{
    internal class MyClass
    {
        int[] ints;
        public MyClass(int num)
        {
            ints = new int[num];
            for(int i = 0; i < num; i++)
            {
                ints[i] = 0;
            }
        }
        public static String operator~(MyClass obj)
        {
            String result = "[";
            for(int i = 0; i < obj.ints.Length - 1; i++)
            {
                result += obj.ints[i] + ", ";
            }
            result += obj.ints[obj.ints.Length - 1] + "]";
            return result;
        }
        public static MyClass operator++(MyClass obj)
        {
            int[] newInts = new int[obj.ints.Length + 1];
            for(int i = 0; i < obj.ints.Length; i++)
            {
                newInts[i] = obj.ints[i];
            }
            newInts[newInts.Length - 1] = 0;
            obj.ints = newInts;
            return obj;
        }
        public static MyClass operator--(MyClass obj)
        {
            int[] newInts = new int[obj.ints.Length - 1];
            for(int i = 0; i < obj.ints.Length - 1; i++)
            {
                newInts[i] = obj.ints[i];
            }
            obj.ints = newInts;
            return obj;
        }
        public static MyClass operator+(MyClass obj1, MyClass obj2)
        {
            int[] newInts = new int[obj1.ints.Length + obj2.ints.Length];
            for(int i = 0; i < obj1.ints.Length; i++)
            {
                newInts[i] += obj1.ints[i];
            }
            for(int i = 0; i < obj2.ints.Length; i++)
            {
                newInts[obj1.ints.Length + i] = obj2.ints[i];
            }
            MyClass result = new MyClass(0);
            result.ints = newInts;
            return result;
        }
        public static MyClass operator+(MyClass obj, int num)
        {
            int[] newInts = new int[obj.ints.Length + 1];
            for (int i = 0; i < obj.ints.Length; i++)
            {
                newInts[i] = obj.ints[i];
            }
            newInts[newInts.Length - 1] = num;
            MyClass result = new MyClass(0);
            result.ints = newInts;
            return result;
        }
        public static MyClass operator+(int num, MyClass obj)
        {
            int[] newInts = new int[obj.ints.Length + 1];
            for (int i = 0; i < obj.ints.Length; i++)
            {
                newInts[i + 1] = obj.ints[i];
            }
            newInts[0] = num;
            MyClass result = new MyClass(0);
            result.ints = newInts;
            return result;
        }

    }
}
