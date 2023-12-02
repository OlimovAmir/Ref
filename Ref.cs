using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    struct MyStract
    {
        public int a;
        public double b;
        public float c;
    }
    class Ref
    {
        static void Foo(ref MyStract myStract)
        {
            myStract.a = -5;
        }

        static void Bar(int[] array) 
        {
            array[0] = -5;
        }
        static void Main(string[] args)
        {
          int a = 2;
            MyStract myStract = new MyStract();
            Foo(ref myStract);

            Console.WriteLine(a);

            //------------------------------------

            int[] myArray = { 1, 4, 6 };

            Bar(myArray);
        }
    }
}
