using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    // UseCase-1 : Checking player Initial Position i.e 0

    public class GamePlay
    {
        public const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        public int playerPosition = 0;
        Random rand = new Random();

        public void diceRoll()
        {
            Console.WriteLine("InitialPosition of Player is: " + playerPosition);
        }
    }
}
