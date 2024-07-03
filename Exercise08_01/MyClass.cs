namespace Exercise08_01
{
    internal class MyClass
    {
        public char symb;

        public static MyClass operator++(MyClass obj)
        {
            obj.symb = (char)(obj.symb + 1);
            return obj;
        }
        public static MyClass operator--(MyClass obj)
        {
            obj.symb = (char)(obj.symb - 1);
            return obj;
        }
        public static MyClass operator+(MyClass obj, int num)
        {
            MyClass newObj = new MyClass();
            newObj.symb = (char)(obj.symb + num);
            return newObj;
        }
        public static int operator-(MyClass obj1, MyClass obj2)
        {
            return obj1.symb - obj2.symb;
        }
    }
}
