using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadderGame

    {
        int playerPosition = 0,count=0;
        const int No_Play=0,Ladder=1, Snake = 2, Winning_Position=100;
        Random random = new Random();
        public int RollingDie()
        {
            int dieNum = random.Next(1, 7);
            count++;
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
                            Console.WriteLine("Player Position =>" + playerPosition);
                            break;
                        case Ladder:
                            int die=RollingDie();
                            playerPosition =playerPosition +die;
                            if(playerPosition>100)
                            {
                                playerPosition= playerPosition-die;
                            }
                            Console.WriteLine("Player Position =>" + playerPosition);
                            break;
                        case Snake:
                            playerPosition -= RollingDie();
                            Console.WriteLine("Player Position =>" + playerPosition);
                            break;
                    }

                }
              
            }
            if (this.playerPosition == Winning_Position)
            {
                Console.WriteLine("Player Position : " + playerPosition);
                Console.WriteLine("Die count => " + count);
            }

        }

    }
}
