using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array.
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int bestSeq = 1;
        int currSeq = 1;
        string currNum = "";
        string bestNum = "";
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                currSeq++;
                currNum += arr[i] + " ";
            }
            else
            {
                if (currSeq > bestSeq)
                {
                    bestSeq = currSeq;
                    currNum += arr[i] + " ";
                    bestNum = currNum;
                }
                currSeq = 1;
                currNum = "";
            }
        }
        if (currSeq > bestSeq)
        {
            currNum += arr[arr.Length - 1];
            bestNum = currNum;
        }
        Console.WriteLine("The maximal increasing sequence is - {0}", bestNum);
    }
}
