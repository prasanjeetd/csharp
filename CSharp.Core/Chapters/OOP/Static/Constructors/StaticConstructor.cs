using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.OOP.Static.Constructors
{
    public class StaticConstructor
    {
        public static DateTime BirthTime;

        static StaticConstructor()
        {
            BirthTime = DateTime.Now;
        }

        public StaticConstructor()
        {
            Console.WriteLine($"Class Birth Time : {BirthTime}");
            var instanceBirthTime = DateTime.Now;
            Console.WriteLine($"Intance Birth Time {instanceBirthTime}");
        }
    }


    public class StaticConTests
    {

        public static void Test()
        {

            StaticConstructor sc1 = new StaticConstructor();
            Thread.Sleep(3000);

            StaticConstructor sc2 = new StaticConstructor();
        }


    }
}
