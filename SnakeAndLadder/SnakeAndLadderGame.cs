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
        public void GameBetweenTwoPlayer()
        {
            bool flag = true;
            int pos = 0;
            while(flag && pos<100)
            {
                Console.WriteLine("1. 1st player  2. 2nd player");
                int Num = Convert.ToInt32(Console.ReadLine());

                switch(Num)
                {
                    case 1:
                       pos = ComputeGame();
                        if(pos == 100)
                        {
                            Console.WriteLine("Player 1 is won");
                            flag = false;
                        }
                        break;
                    case 2:
                       pos= ComputeGame();
                        if (pos == 100)
                        {
                            Console.WriteLine("Player 2 is won");
                            flag = false;
                        }
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
        public int ComputeGame()
        {
           
                if (playerPosition < 0)
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
                           for(int i=0;i<2;i++)
                           {
                            int die = RollingDie();
                            playerPosition = playerPosition + die;
                            if (playerPosition > 100)
                            {
                                playerPosition = playerPosition - die;
                            }
                            Console.WriteLine("Player Position =>" + playerPosition);
                           }
                            
                            break;
                        case Snake:
                            playerPosition -= RollingDie();
                            Console.WriteLine("Player Position =>" + playerPosition);
                            break;
                    }

                }
            return playerPosition;
            }
   

        

    }
}
