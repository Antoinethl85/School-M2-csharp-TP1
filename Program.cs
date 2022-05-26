using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TP1
{
    class Start
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exo1");
            tableOf();

            Console.WriteLine("Exo2.1");
            Prime(1000);
/*
            Console.WriteLine("Please Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exo2.2");
            F(number);

            Console.WriteLine("Exo2.3");
            Factorial(number);

            Console.WriteLine("Exo3");
            Ftry(number);

            Console.WriteLine("Please enter n :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter m :");
            int m = Convert.ToInt32(Console.ReadLine());
            square(n, m);
            */
            chrismasTree(6);
        }

        public static void tableOf()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i*j % 2 == 1)
                    {
                        Console.WriteLine(i + "x" + j + "=" + i * j);
                    }
                }
            }
        }

        public static void Prime(int n)
        {
            List<int> prime = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (Math.Sqrt(i).GetType() != typeof(int))
                {
                    prime.Add(i);
                }
            }
            Console.WriteLine(prime.ToString());
        }

        public static int F(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }
            else
            {
                return F(n - 1) + F(n - 2);
            }
        }

        public static double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void Ftry(int n)
        {
            for (int i = -3; i < 4; i++)
            {
                int x = PowerFunction(i);
                try
                {
                    int result = 10 / i;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Error function try");
                }
            }
        }

        public static void square(int n, int m)
        {
            string rectangle = "";
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < m+1; j++)
                {
                    if ((i == 1 && j == 1) || (i == n && j == m) || (i == 1 && j == m) || (i == n && j == 1))
                    {
                        rectangle += "0";
                    }
                    else if (i == 1 || i == n)
                    {
                        rectangle += "-";
                    }
                    else if (j == 1 || j == m)
                    {
                        rectangle += "|";
                    }
                    else
                    {
                        rectangle += " ";
                    }
                }
                rectangle += "\n";
            }
            Console.WriteLine(rectangle);
        }

        public static void chrismasTree(int n)
        {
            string tree = "";
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < n+1; j++)
                {
                    if ((i == n && j/2 == n-1) || (i == n && j/2 == n+1))
                    {
                        tree += "|";
                    }
                    else if (j == n/2)
                    {
                        tree += "*";
                    }
                }
                tree += "\n";
            }
            Console.WriteLine(tree);
        }
    }
}