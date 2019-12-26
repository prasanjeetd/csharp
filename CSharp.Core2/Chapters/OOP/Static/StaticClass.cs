using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.OOP.Static
{
    public class StaticClass
    {
        private int nonStaticVar = 1;
        private static int staticVar = 2;

        static StaticClass()
        {
            //nonStaticVar = 3;
            staticVar = 4;

            Console.WriteLine($"Static cons :staticVar=>{staticVar}");
        }

        public StaticClass()
        {
            nonStaticVar = 5;
            staticVar = 6;

            Console.WriteLine($"Public cons:nonStaticVar  =>{nonStaticVar}");
            Console.WriteLine($"Public cons:staticVar =>{staticVar}");
        }

        public void nonStaticMethod()
        {
            nonStaticVar = 7;
            staticVar = 8;

            Console.WriteLine($"nonStaticMethod: nonStaticVar  =>{nonStaticVar}");
            Console.WriteLine($"nonStaticMethod: staticVar =>{staticVar}");
        }

        public static void staticMethod()
        {
            //nonStaticVar = 5; //Non static variable not accesible
            staticVar = 10;

            StaticClass statClass = new StaticClass();
            statClass.nonStaticVar = 9;

            Console.WriteLine($"nonStaticMethod : statClass.nonStaticVar=>{statClass.nonStaticVar}");
            Console.WriteLine($"nonStaticMethod : staticVar =>{staticVar}");

        }

        public static void staticMethod(bool type)
        {

        }

    }

    public class StaticClassTests
    {
        public static void Test()
        {

            StaticClass sc = new StaticClass();
            sc.nonStaticMethod();
            StaticClass.staticMethod();
        }
    }
}
