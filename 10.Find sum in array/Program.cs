using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present).
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter S: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers for the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int currSum = 0;
            int startIndex = 0;

            for (int i = 0; i < n - 1; i++)
            {
                currSum += arr[i];
                startIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    currSum += arr[j];
                    if (currSum == s)
                    {
                        for (int k = startIndex; k <= j; k++)
                        {
                            Console.Write("{0} ", arr[k]);
                        }
                        break;
                    }
                }
                currSum = 0;
            }
            Console.WriteLine();
        }
    }
