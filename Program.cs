using System;

namespace Mission2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Array to keep track of sums 2 through 12.
            // Index 0 = sum of 2, Index 10 = sum of 12.
            int[] finalRolls = new int[11];

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            string input = Console.ReadLine();

            // Convert the text input to an integer
            if (int.TryParse(input, out int numberOfRolls))
            {
                DiceRoller roller = new DiceRoller();

                // Call the class and get the array of raw results back
                int[] allResults = roller.RollMultipleTimes(numberOfRolls);

                // Process the raw results to fill our frequency array (finalRolls)
                for (int i = 0; i < allResults.Length; i++)
                {
                    int rolledNumber = allResults[i];
                    // Increment the counter for that number. 
                    // We subtract 2 because index 0 represents the number 2.
                    finalRolls[rolledNumber - 2]++;
                }

                // Display the specific header info required
                Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
                Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
                Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

                // Loop from 2 to 12 (the possible dice sums)
                for (int i = 2; i <= 12; i++)
                {
                    // Calculate the percentage
                    double percentage = ((double)finalRolls[i - 2] / numberOfRolls) * 100;

                    // Round the percentage to the nearest whole number for the stars
                    int numStars = (int)Math.Round(percentage);

                    // Create the string of asterisks
                    string stars = new string('*', numStars);

                    // Print the result (e.g., "2: ***")
                    Console.WriteLine($"{i}: {stars}");
                }

                Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}