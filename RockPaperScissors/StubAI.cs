using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubAI : IPlayer
    {
        int favMove;

        public StubAI ()
        {
            favMove = 1;
        }

        public int NextMove()
        {
           return favMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
           //do nothing
        }
    }
}
