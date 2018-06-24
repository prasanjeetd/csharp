using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.GC
{
    public class DPDerivedClass : DisposablePattern
    {
        bool disposed = false;

        public void SayHello()
        {
            Console.WriteLine("Say hello!");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                //Clean code
            }

            disposed = true;
            base.Dispose(disposing);
        }

        ~DPDerivedClass()
        {
            Dispose(false);
        }
    }

    public class TestDisposePattern
    {

        public static void Test()
        {
            using( var obj = new DPDerivedClass())
            {
                obj.SayHello();
            }
        }
    }
}
