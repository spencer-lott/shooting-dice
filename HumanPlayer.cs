using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("You are the human player (Wilma). Please input an integer as your roll!");
            string input = Console.ReadLine();
            int parsedInput = int.Parse(input); 
            return parsedInput;
        }
    }
}