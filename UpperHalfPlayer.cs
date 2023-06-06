using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose roll will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
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
    }
}