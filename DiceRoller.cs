﻿namespace DiceSimuilatorpt2
{
    class DiceRoller
    {
        // make a method that takes number of rolls and shows
        // frequency of each dice roll sum
        public int[] SimulateRolls(int numberOfRolls)
        {
            Random random = new Random();
            int[] results = new int[11];
            // rolls the dice for the specified number of dice rolls
            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                results[sum - 2]++;
            }
            // returns the results to the previous class written
            return results;
        }
    }
}

