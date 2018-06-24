using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance3
{
    class A
    {
        public  virtual void One()
        {
            Console.WriteLine("Base one");
        }

        public void Two()
        {
            Console.WriteLine("Base two");
        }
    }

    class B:A
    {
        public override void One()
        {
            Console.WriteLine("Derived one");
        }

        public void Two()
        {
            Console.WriteLine("Derived two");
        }
    }

    public class InTester3
    {
        public static void Test()
        {

            B b = new B();

            A ab = b;

            ab.One();
            ab.Two();

            b.One();
            b.Two();

        }

    }
}
