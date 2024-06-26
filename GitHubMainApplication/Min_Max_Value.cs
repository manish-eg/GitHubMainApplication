﻿using System;

namespace GitHubMainApplication
{
    internal class Min_Max_Value
    {
        public void findMinMaxValue(int[] numberArray, int countOfNumbers)
        {
            int maxNumberInArray = numberArray[0];
            int minNumberInArray = numberArray[0];

            for (int iterator = 1; iterator < countOfNumbers; iterator++)
            {
                if (maxNumberInArray < numberArray[iterator])
                    maxNumberInArray = numberArray[iterator];
                if (minNumberInArray > numberArray[iterator])
                    minNumberInArray = numberArray[iterator];
            }
            Console.WriteLine($"The maximum value in the array is {maxNumberInArray}");
            Console.WriteLine($"The minimum value in the array is {minNumberInArray}");
        }
    }
}
