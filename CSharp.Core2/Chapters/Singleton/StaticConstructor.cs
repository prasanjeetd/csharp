using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Singleton
{
    public class Bus
    {
        private static DateTime startTime;
        private string name;

        static Bus()
        {
            startTime = new DateTime();
        }

        public Bus(string name)
        {
            this.name = name;
        }


    }
}
