using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Singleton
{
    public sealed class ThreadSafeLazySingleton
    {
        private ThreadSafeLazySingleton()
        {
        }

        public static ThreadSafeLazySingleton GetInstance
        {
            get
            {
                return Instance.instance;
            }
        }

        private class Instance
        {

            static Instance()
            {
            }

            internal static readonly ThreadSafeLazySingleton instance = new ThreadSafeLazySingleton();
        }
    }
}
