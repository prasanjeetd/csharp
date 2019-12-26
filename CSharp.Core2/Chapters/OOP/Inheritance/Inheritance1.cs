using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.OOP
{
    class A
    {
        public virtual void Method()
        {
            Console.WriteLine("A Method");
        }
    }

    class B : A
    {
        public virtual  void Method()
        {
            Console.WriteLine("B Method");
        }
    }

    class C : B
    {
        public override void Method()
        {
            Console.WriteLine("C Method");
        }
    }


   public class InTester
    {
        public static void Test()
        {
            Console.WriteLine("----------------------------");
            A ab = new B();
            ab.Method();

            A ac = new C();
            ac.Method();

            B bc = new C();
            bc.Method();

            Console.WriteLine("----------------------------");


        }
    }


}
