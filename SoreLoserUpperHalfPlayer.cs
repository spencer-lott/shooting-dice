using System;
using System.Collections.Generic;
using System.Linq;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            Random rand = new Random();
            int roll = rand.Next(DiceSize) + 1;

            while (roll <= 3)
            {
                roll = rand.Next(DiceSize) + 1;
            }

            return roll;

        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();


            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            try
            {

                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins! IN YOUR FACE!");
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"Game over. {other.Name} Wins!");
                    throw new Exception("ARE YOU KIDDING ME?!?! HOW'D I LOSE TO A LOW-LIFE LIKE YOU?! I EVEN CHEAT! AHHHHHHHHHHHHHH!!! (throws dice at opponent and then fights them)");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
