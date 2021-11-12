using System;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Snake And Ladder game");
            GamePlay playerl = new GamePlay();
            playerl.diceRoll();
            GamePlay Roll = new GamePlay();
            Roll.play();
            GamePlay option = new GamePlay();
            option.rolling();
            GamePlay repeatiton = new GamePlay();
            repeatiton.repeat();
        }
    }
}