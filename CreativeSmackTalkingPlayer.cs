using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {


        static List<string> AllTaunts = new List<string>()
        {
            "I roll dice like Snoop Dogg lives life... HIGH!",
            "I'll have my dice say hello to the I.S.S. as they go by...",
            "Whats the difference in my dice and Bill Gates bank acocunt? My Dice have bigger numbers"
        };



        static int secretNumber = new Random().Next(0, 3);

        static string Taunt = AllTaunts[secretNumber];

        public override int Roll()
        {
            Console.WriteLine($"{Name} shouts '{Taunt}' as the die is rolled...");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

    }
}