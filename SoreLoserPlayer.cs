using System;

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
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
                try
                {
                    int crashNumber = 0;
                    int boom = 1 / crashNumber;
                }
                catch
                {
                    Console.WriteLine($"{Name} says 'I WON THE GAME! THIS GAME IS RIGGED! EVERYBODYS TALKIN ABOUT IT! RIGGED! I WON THE GAME! RUUUUUUUUDYYYYY!!!!!!!");
                }
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}