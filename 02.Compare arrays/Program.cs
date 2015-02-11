using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            //Write a program that reads two integer arrays from the console and compares them element by element.
            Console.Write("Enter the first array lenght: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the second array lenght: ");
            int m = int.Parse(Console.ReadLine());
            bool compare = false;
            if (n == m)
            {
                int[] arr = new int[n];
                Console.WriteLine("Enter {0} numbers from the first array: ", n);
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int[] arr1 = new int[m];
                Console.WriteLine("Enter {0} numbers from the second array: ", m);
                for (int i = 0; i < m; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                }
                foreach (int num in arr)
                {
                    foreach (int number in arr1)
                    {
                        if (num == number)
                        {
                            compare = true;
                        }
                        else
                        {
                            compare = false;
                        }
                    }
                }
                if (compare == true)
                {
                    Console.WriteLine("The two arrays are the same");
                }
                else
                {
                    Console.WriteLine("The two arrays are not the same");
                }
            }
            else
            {
                Console.WriteLine("The lenght of the two arrays is different");
            }
            
        }
    }
