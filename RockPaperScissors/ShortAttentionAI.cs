using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionAI : IPlayer
    {
        int winMove;

        public int NextMove()
        {
            return winMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            
            if (otherMove == 0)
            {
                winMove = 1;
            }
            else if (otherMove == 1)
            {
                winMove = 2;
            }
            else if (otherMove == 2)
            {
                winMove = 0;
            }
        }
    }
}


