using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = new Singleton();

        static Singleton()
        {
        }

        private Singleton() { }

        public static Singleton Instance
        {
            get { return instance; }
        }
    }


    public sealed class Singleton1
    {
        private static Singleton1 instance = new Singleton1();
        public static DateTime initializeTime;

        static Singleton1()
        {
            initializeTime = new DateTime();
        }

        private Singleton1()
        {
        }

        public static Singleton1 GetInstance
        {
            get
            {
                return instance;
            }
        }

    }
}
