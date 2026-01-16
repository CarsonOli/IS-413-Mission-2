using System;

namespace Mission2
{
    public class DiceRoller
    {
        public int[] RollMultipleTimes(int numberOfRolls)
        {
            // Create a Random object to generate numbers
            Random rnd = new Random();

            // Create an array to hold the result of every single roll
            int[] rollResults = new int[numberOfRolls];

            for (int i = 0; i < numberOfRolls; i++)
            {
                // Simulate two 6-sided dice
                int die1 = rnd.Next(1, 7); // Generates 1-6
                int die2 = rnd.Next(1, 7); // Generates 1-6

                int sum = die1 + die2;

                // Store the result in the array
                rollResults[i] = sum;
            }

            return rollResults;
        }
    }
}