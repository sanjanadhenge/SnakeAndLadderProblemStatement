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
        const int No_Play=0,Ladder=1, Snake = 2, Winning_Position=100;
        Random random = new Random();
        public int RollingDie()
        {
            int dieNum = random.Next(1, 7);
            return dieNum;
           
        }
        public void ComputeGame()
        {
            while(playerPosition<100)
            {
                if(playerPosition<0)
                {
                    playerPosition = 0;
                }
                else
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
            if (this.playerPosition == Winning_Position)
            {
                Console.WriteLine("Player Position : " + playerPosition);
            }

        }

    }
}
