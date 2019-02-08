using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.StatePattern.WithoutStates
{
    public class CeilingFanPullChain
    {
        private int _currentState;

        public CeilingFanPullChain()
        {
            _currentState = 0;
        }

        public void Pull()
        {
            if (_currentState == 0)
            {
                _currentState = 1;
                Console.WriteLine("low speed");
            }
            else if (_currentState == 1)
            {
                _currentState = 2;
                Console.WriteLine("medium speed");
            }
            else if (_currentState == 2)
            {
                _currentState = 3;
                Console.WriteLine("high speed");
            }
            else
            {
                _currentState = 0;
                Console.WriteLine("turning off");
            }
        }


    }
}
