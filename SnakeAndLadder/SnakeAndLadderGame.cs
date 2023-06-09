using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadderGame

    {
        int playerPosition = 0;
        const int No_Play=0,Ladder=1, Snake = 2;
        Random random = new Random();
        int position = 0;
        public int RollingDie()
        {
            int dieNum = random.Next(1, 7);
            return dieNum;
           
        }
        public void ComputeGame()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case No_Play:
                    break;
                case Ladder:
                    this.playerPosition += RollingDie();
                    break;
                case Snake:
                    this.playerPosition -= RollingDie();
                    break;
            }
        }

    }
}
