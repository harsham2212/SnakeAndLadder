using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    // UseCase-1 : Checking player Initial Position i.e 0

    public class GamePlay
    {
        public const int NO_PLAY = 0, SNAKE = 1, LADDER = 2, WIN = 100, START = 0;
        public int playerPosition = 0;
        public int standingPositionofPlayer = 0;
        public int count = 0;
        Random rand = new Random();


        //public void diceRoll()
        //{
        //    Console.WriteLine("InitialPosition of Player is: " + playerPosition);
        //}

        //// UseCase-2 : Random Dice Value between 1 to 6

        //public int dice()
        //{
        //    int roll = rand.Next(1, 7);
        //    return roll;
        //}
        //public void play()
        //{
        //    int Roll = this.dice();
        //    this.playerPosition = playerPosition + Roll;
        //    Console.WriteLine("The value when Dice thrown is: " + playerPosition);
        //}

        //// UseCase-3 : Option Check to play or not

        //public int roll()
        //{
        //    int roll = rand.Next(1, 7);
        //    return roll;
        //}
        //public void rolling()
        //{
        //    int Roll = this.roll();
        //    int Check = rand.Next(0, 3);
        //    switch (Check)
        //    {
        //        case NO_PLAY:
        //            this.playerPosition += NO_PLAY;
        //            break;
        //        case LADDER:
        //            this.playerPosition += Roll;
        //            break;
        //        case SNAKE:
        //            this.playerPosition += Roll;
        //            break;
        //        default:
        //            //Console.WriteLine("dicenumber must be between 1 to 6");
        //            break;
        //    }
        //    Console.WriteLine("player position is " + this.playerPosition);
        //}

        //// UseCase-4 : Repeat till the Player reaches the winning position 100

        //public int diceThrow()
        //{
        //    int roll = rand.Next(1, 7);
        //    return roll;
        //}
        //public void repeat()
        //{
        //    {
        //        while (this.playerPosition < WIN)
        //        {
        //            int Roll = this.diceThrow();
        //            int Check = rand.Next(0, 3);
        //            switch (Check)
        //            {
        //                case NO_PLAY:
        //                    break;
        //                case LADDER:
        //                    this.playerPosition += Roll;
        //                    break;
        //                case SNAKE:
        //                    this.playerPosition -= Roll;
        //                    if (this.playerPosition < 0)
        //                    {
        //                        this.playerPosition = 0;
        //                    }
        //                    break;
        //            }

        // UseCase-5 : Ensure the player gets to exact winning

        //         public int DieRolling()
        //         {
        //             int roll = rand.Next(1, 7);
        //             return roll;
        //         }
        //         public void PlayerCheck()
        //         {
        //             while (standingPositionofPlayer < WIN)
        //             {
        //                 int dieRoll = this.DieRolling();
        //                 int option = rand.Next(0, 3);
        //                 switch (option)
        //                 {
        //                     case NO_PLAY:
        //                         break;
        //                     case LADDER:
        //                         this.standingPositionofPlayer += dieRoll;
        //                         if (this.standingPositionofPlayer > WIN)
        //                         {
        //                             this.standingPositionofPlayer -= dieRoll;
        //                         }
        //                         break;
        //                     case SNAKE:
        //                         this.standingPositionofPlayer -= dieRoll;
        //                         if (this.standingPositionofPlayer < START)
        //                         {
        //                             this.standingPositionofPlayer = START;
        //                         }
        //                         break;
        //                 }
        //                 //Console.WriteLine("The standin Position of Player is :" + this.standingPositionofPlayer + " " + "with a roll of " + dieRoll);
        //             }
        //             Console.WriteLine("The Player wins the Game");
        //}

        //UseCase 6: Report the number of times the dice was played to win the game and also the position after every die role


        public int DieRolling()
        {
            int roll = rand.Next(1, 7);
            return roll;
        }
        public void PlayerCheck()
        {
            while (standingPositionofPlayer < WIN)
            {
                int dieRoll = this.DieRolling();
                int option = rand.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.standingPositionofPlayer += dieRoll;
                        if (this.standingPositionofPlayer > WIN)
                        {
                            this.standingPositionofPlayer -= dieRoll;
                        }
                        Console.WriteLine("Got Ladder");
                        break;
                    case SNAKE:
                        this.standingPositionofPlayer -= dieRoll;
                        if (this.standingPositionofPlayer < START)
                        {
                            this.standingPositionofPlayer = START;
                        }
                        Console.WriteLine("Got Snake");
                        break;
                }
                count++;
                Console.WriteLine("The Player Position is :" + this.standingPositionofPlayer + " " + "with a roll of " + dieRoll);
            }
            Console.WriteLine("The number of times dice was rolled to win the Game is : " + count);
            Console.WriteLine("The Player wins the Game");
        }
    }
}
 //}
//        }
//    }
//}
