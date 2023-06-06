using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
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
                    throw new Exception("YOU GOT SO LUCKY! I'M NEVER PLAYING THIS STUPID GAME AGAIN! AHHHHHHHHHHHHHH!!!!!! (throws dice at opponent and flips the table)");
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
