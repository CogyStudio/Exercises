using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_04
{
    internal class MyClass
    {
        public int num;
        public String text;
        public static bool operator>(MyClass a, MyClass b)
        {
            if(a.text.Length > b.text.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator<(MyClass a, MyClass b)
        {
            if (a.text.Length < b.text.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator>=(MyClass obj1, MyClass obj2)
        {
            if(obj1.num > obj2.num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(MyClass obj1, MyClass obj2)
        {
            if (obj1.num < obj2.num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            int result = (int)Math.Pow(num, 7);
            for(int i = 0; i < text.Length; i++)
            {
                result += (int)Math.Pow(text[i], i + 11);
            }
            return result;
            
        }
        public override bool Equals(object obj)
        {
            if(this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator==(MyClass obj1, MyClass obj2)
        {
            return obj1.Equals(obj2);
        }
        public static bool operator !=(MyClass obj1, MyClass obj2)
        {
            return !(obj1.Equals(obj2));
        }
    }
}
