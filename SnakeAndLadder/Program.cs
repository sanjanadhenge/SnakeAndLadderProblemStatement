using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To SnakeLadder");
            SnakeAndLadderGame game = new SnakeAndLadderGame();
            game.RollingDie();
        }

    }
}
