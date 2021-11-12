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

        // UseCase-2 : Random Dice Value between 1 to 6

        public int dice()
        {
            int roll = rand.Next(1, 7);
            return roll;
        }
        public void play()
        {
            int Roll = this.dice();
            this.playerPosition = playerPosition + Roll;
            Console.WriteLine("The value when Dice thrown is: " + playerPosition);
        }
    }
}
