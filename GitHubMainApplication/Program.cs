﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMainApplication
{
    public class Program
    {
        static void displayOptions() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1- Insert an element");
            Console.WriteLine("2- Delete an element");
            Console.WriteLine("3- Sort the elements");
            Console.WriteLine("4- Count of elements in the array");
            Console.WriteLine("5- Compute the average of all values ");
            Console.WriteLine("6- Find the maximum and minimum value");
            Console.WriteLine("7- Calculate total of all the values");
            Console.WriteLine("8- Exit");
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("Enter your choice:");
        }
        static void Main(string[] args)
        {
            int countOfNumbers=0;
            int[] numbersArray=new int[15];
            int choice;

            Console.Write("Enter the number of elements: ");
            countOfNumbers = Convert.ToInt32(Console.ReadLine());

            for (int iterator = 0; iterator < countOfNumbers; iterator++) {
                Console.Write($"Enter the number-{iterator}: ");
                numbersArray[iterator]=Convert.ToInt32(Console.ReadLine());
            }

            do {
                displayOptions();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Insertion.Insert(numbersArray, countOfNumbers);
                        countOfNumbers++;
                        break;
                    case 2:
                        GitHubMainApplication.DeletionOperation.Deletion(numbersArray, countOfNumbers);
                        countOfNumbers--;
                        break;
                    case 3: SortOperation sortOperation = new SortOperation(numbersArray, countOfNumbers);
                        break;
                    case 4:
                        CountingAndAverage countObj = new CountingAndAverage();
                        countObj.count(countOfNumbers);
                        break;
                    case 5:
                        CountingAndAverage averageObj = new CountingAndAverage();
                        averageObj.average(numbersArray, countOfNumbers);
                        break;
                    case 6:
                        Min_Max_Value minMaxValueObj= new Min_Max_Value();
                        minMaxValueObj.findMinMaxValue(numbersArray, countOfNumbers);
                        break;
                    case 7:TotalOfAllValues totalOfAllValuesObj=new TotalOfAllValues();
                        totalOfAllValuesObj.calculateTotalOfAllValues(numbersArray);
                            break;
                    default: 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while(choice!=8);

        }
    }
}
