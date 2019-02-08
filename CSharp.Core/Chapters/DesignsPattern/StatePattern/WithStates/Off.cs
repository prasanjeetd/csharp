using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.StatePattern.WithStates
{
    class Off  : State
    {
        public void Pull(CeilingFanPullChain wrapper)
        {
            wrapper.SetState(new Low());
        }
    }
}
