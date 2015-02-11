using System;
    class Program
    {
        static void Main()
        {
            //Write a program that compares two char arrays lexicographically (letter by letter).
            Console.Write("Enter the first array lenght: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the second array lenght: ");
            int m = int.Parse(Console.ReadLine());
            bool compare = false;
            if (n == m)
            {
                char[] arr = new char[n];
                Console.WriteLine("Enter {0} chars from the first array: ", n);
                for (int i = 0; i < n; i++)
                {
                    arr[i] = char.Parse(Console.ReadLine());
                }
                char[] arr1 = new char[m];
                Console.WriteLine("Enter {0} chars from the second array: ", m);
                for (int i = 0; i < m; i++)
                {
                    arr1[i] = char.Parse(Console.ReadLine());
                }
                foreach (char sym in arr)
                {
                    foreach (char symbol in arr1)
                    {
                        if (sym == symbol)
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
