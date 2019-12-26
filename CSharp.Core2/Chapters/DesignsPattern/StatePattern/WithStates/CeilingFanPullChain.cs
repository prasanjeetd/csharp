using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.StatePattern.WithStates
{
    public class CeilingFanPullChain
    {
        private State _state;

        public CeilingFanPullChain()
        {
            _state = new Off();
        }

        public void SetState(State state)
        {
            _state = state;
        }

        public void Pull()
        {
            _state.Pull(this);
        }

    }
}
