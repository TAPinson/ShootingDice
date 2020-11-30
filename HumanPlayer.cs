using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter a number to roll");
            string response = Console.ReadLine();
            int userNumber = Int16.Parse(response);
            // Return a random number between 1 and DiceSize
            return userNumber;
        }
    }
}