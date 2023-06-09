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
        Random random = new Random();
        public void RollingDie()
        {
            int dieNum = random.Next(1, 7);
            Console.WriteLine(dieNum);
        }


    }
}
