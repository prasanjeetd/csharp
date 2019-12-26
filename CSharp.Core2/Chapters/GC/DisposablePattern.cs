using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.GC
{
    public class DisposablePattern : IDisposable
    {
        private bool disposed = false;

        SafeHandle safeHandle = new SafeFileHandle(IntPtr.Zero,true);

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                safeHandle.Dispose();
            }

            disposed = true;
        }

        ~DisposablePattern()
        {
            Dispose(false);
        }


    }
}
