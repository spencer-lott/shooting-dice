using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        // public string Taunt { get; set; }
    static string Taunter() {

    List<string> tauntsList = new List<string> {
        "You should be scared...",
        "You stand no chance!",
        "I am a world-renowned dice thrower. Prepare yourself.",
        "You are no match for me!",
        "Let's see what you got, chump.",
        };


            int randomValue = getRandomInt();
            string insult = tauntsList[randomValue];
            return insult;

        int getRandomInt()
        {
            Random rand = new Random();
            int randomVal = new Random().Next(0, 5);
            return randomVal;
        }

        }

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            string taunt = Taunter();
            Console.WriteLine($"{Name} says: {taunt}");
            return new Random().Next(DiceSize) + 1;
        }
    }
}