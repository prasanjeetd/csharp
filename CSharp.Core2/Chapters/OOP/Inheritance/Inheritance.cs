using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.OOP
{
    class Base
    {
        public void Method()
        {
            Console.WriteLine("Base Method");
        }

        public virtual void VirtualMethod1()
        {
            Console.WriteLine("Base VitualMethod1");
        }

        public virtual void VirtualMethod2()
        {
            Console.WriteLine("Base VitualMethod2");
        }

        public virtual void VirtualMethod3()
        {
            Console.WriteLine("Base VitualMethod3");
        }

        public virtual void Method1()
        {
            Console.WriteLine("Base Method");
        }
    }

    class Derived1 : Base
    {
        public void Method()
        {
            Console.WriteLine("Derived1 Method");
        }

        public virtual void VirtualMethod1()
        {
            Console.WriteLine("Derived1 VitualMethod");
        }

        public override void VirtualMethod2()
        {
            Console.WriteLine("Derived1 VitualMethod2");
        }

        public void VirtualMethod3()
        {
            Console.WriteLine("Derived1 VitualMethod3");
        }

        public new virtual void Method1()
        {
            Console.WriteLine("Derived1 Method");
        }
    }

    class Derived2 : Derived1
    {
        public new void VirtualMethod2()
        {
            Console.WriteLine("Derived2 VitualMethod2");
        }
    }

    public class OOPTests
    {

        public static void Test()
        {
            Derived1 d1 = new Derived1();
            Base b = new Derived1();

            Console.WriteLine("------------Same methods--------------");
            d1.Method();
            b.Method();

            Console.WriteLine("------------Vitaul methods no overrides and make again vitauls--------------");
            d1.VirtualMethod1();
            b.VirtualMethod1();

            Console.WriteLine("------------Vitaul methods override--------------");
            d1.VirtualMethod2();
            b.VirtualMethod2();

            Console.WriteLine("------------Vitaul methods no override no virtual--------------");
            d1.VirtualMethod3();
            b.VirtualMethod3();

            Console.WriteLine("------------Same methods with new keywords--------------");
            d1.Method1();
            b.Method1();

            Console.WriteLine("------------Inheritance with Devied1 and Derived2--------------");
            Base b1 = new Derived2();
            Derived1 d2 = new Derived2();

            Console.WriteLine("------------Same methods--------------");
            b1.Method();
            d2.Method();

            Console.WriteLine("------------Vitaul methods no overrides and make again vitauls--------------");
            b1.VirtualMethod1();
            d2.VirtualMethod1();

            Console.WriteLine("------------Vitaul methods override--------------");
            b1.VirtualMethod2();
            d2.VirtualMethod2();

            Console.WriteLine("------------Vitaul methods no override no virtual--------------");
            b1.VirtualMethod3();
            d2.VirtualMethod3();

            Console.WriteLine("------------Same methods with new keywords--------------");
            b1.Method1();
            d2.Method1();


        }
    }
}
