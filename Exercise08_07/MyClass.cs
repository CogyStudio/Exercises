using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08_07
{
    internal class MyClass
    {
        public String text;
        public static implicit operator int(MyClass obj)
        {
            return obj.text.Length;
        }
        public static implicit operator char(MyClass obj)
        {
            return obj.text[0];
        }
        public static implicit operator MyClass(int num)
        {
            String text = "";
            for(int i = 0; i < num; i++)
            {
                text += "A";
            }
            MyClass result = new MyClass();
            result.text = text;
            return result;
        }
    }
}
