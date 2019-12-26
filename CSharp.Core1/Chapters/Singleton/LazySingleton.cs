using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Singleton
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> instanceHolder =
            new Lazy<LazySingleton>(()=> new LazySingleton());

        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get
            {
                return instanceHolder.Value;
            }
        }
    }
}
