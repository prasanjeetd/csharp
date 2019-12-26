using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Singleton
{
    public class ThreadSafeSingleton
    {
        private static readonly ThreadSafeSingleton _instance = new ThreadSafeSingleton();

        private ThreadSafeSingleton()
        {
        }

        static ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get { return _instance; }
        }

    }
}
