using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random rand;

        public RandomAI ()
        {
            rand = new Random();
        }

        public int NextMove()
        {
            return rand.Next(3);
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //do nothing
        }
    }
}
