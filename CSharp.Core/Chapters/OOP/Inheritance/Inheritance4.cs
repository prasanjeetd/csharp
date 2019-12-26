using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.OOP.Inheritance
{
    public class A
    {
        public A() { }

        public virtual void show()
        {

            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public B() { }

        public virtual void show()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public C()
        {
        }

        public override void show()
        {
            Console.WriteLine("C");
        }
    }

    public class OPPTester
    {

        public static void Test()
        {
            A a = new A();

            B b = new B();

            C c = new C();


            A a1 = new B();


            //B b1 = new A();//wrong

            A a2 = new C();
            Console.WriteLine("Test for a2");
            a2.show();  //C

            A a3 = new B();
            Console.WriteLine("Test for a3");
            a3.show(); //A

            C c1 = new C();
            Console.WriteLine("Test for a2");
            c1.show(); //C

            B b1 = new B();
            Console.WriteLine("Test for a3");
            b1.show(); //B

        }
    }

    
}
